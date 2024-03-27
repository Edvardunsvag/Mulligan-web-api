using Microsoft.EntityFrameworkCore;
using MulliganApi.Database.Enums;
using MulliganApi.Database.Models;
using MulliganApi.Dto;

namespace MulliganApi.Database.Repository
{
    public class MulliganRepository : IMulliganRepository
    {
        private readonly MulliganDbContext _dbContext;
        public MulliganRepository(MulliganDbContext dbContext) {
            _dbContext = dbContext;
        }

        //Course
        public List<Course> GetAllCourses()
        {
            var course = _dbContext.Course.Include(x => x.CourseHoles).ToList();
            return course;
        }

        public List<CourseTeeBox> GetTeeBoxes(Guid courseId)
        {
            var teeBoxes = _dbContext.TeeBoxes.Where(x => x.CourseId == courseId).ToList();
            return teeBoxes;
        }

        //Hole
        public CourseHole GetHoleById(Guid id)
        {
            var hole =  _dbContext.CourseHole.Where(x => x.Id == id).FirstOrDefault();
            return hole;
        }

        public List<CourseHole> GetAllHolesForCourse(Guid courseId)
        {
            var holes = _dbContext.CourseHole.Include(x => x.Notes).Where(x => x.CourseId == courseId).ToList();
            return holes;
        }

        //Round
        public async Task<Round> AddRound(Round round)
        {
            await _dbContext.Round.AddAsync(round);
            return round;
        }
        
        public Round GetRound(Guid roundId)
        {
            var rounds = _dbContext.Round.Include(x => x.Holes).First(x => x.RoundId == roundId);
            return rounds;
        }

        public List<Round> GetAllRounds()
        {
            var rounds =  _dbContext.Round.Include(x => x.Holes).ToList();
            return rounds;
        }
        
        public async Task<Guid> DeleteRound(Round round)
        {
             _dbContext.Round?.Remove(round);
            await _dbContext.SaveChangesAsync();
            return round.RoundId;
        }

        public List<Round> GetAllRoundsForUser(Guid id)
        {
            var rounds = _dbContext.Round.Include(x => x.Holes).Where(x => x.UserId == id).ToList();
            return rounds;
        }
        
        //Note
        public List<Note> GetAllCourseNotes(Guid userId)
        {
            var notes = _dbContext.Note.Include(x => x.CourseHole).Where(hole => hole.UserId == userId).ToList();
            return notes;
        }

        public Note GetNoteById(Guid noteId)
        {
            var note = _dbContext.Note.First(x => x.Id == noteId);
            return note;
        }
        
        public async Task UpdateNote(Note updatedNote)
        {
            _dbContext.Entry(updatedNote).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteNote(Note note)
        {
            _dbContext.Note.Remove(note);
            await _dbContext.SaveChangesAsync();
        }

        public List<User> GetAllUsers()
        {
            var users = _dbContext.User.AsNoTracking().ToList();
            return users;
        }

        public async Task AddNote(Note note)
        {
            await _dbContext.Note.AddAsync(note);
        }

        //User
        public async Task AddUser(User user)
        {
            await _dbContext.User.AddAsync(user);
        }

        public async Task<User> DeleteUser(User user)
        {
            _dbContext.User.Remove(user);
            await _dbContext.SaveChangesAsync(); 
            return user;
        }

        public async Task AddUserRating(UserRatings userRating)
        {
            await _dbContext.UserRating.AddAsync(userRating);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<UserRatings>> GetAllUserRatings()
        {
            var allRatings = await _dbContext.UserRating.Include(x => x.User).ToListAsync();
            return allRatings;
        }

        public async Task Save()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateUser(User user)
        {
            _dbContext.Entry(user).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task AddAdminRoleToUser(UserRole adminRole, User user)
        {
            _dbContext.Entry(user.Roles).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
