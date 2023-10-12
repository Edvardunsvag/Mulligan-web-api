using Microsoft.EntityFrameworkCore;
using MulliganApi.Data;
using MulliganApi.Database.Models;

namespace MulliganApi.Database.Repository
{
    public class MulliganRepository : IMulliganRepository
    {
        private readonly MulliganDbContext _dbContext;
        public MulliganRepository(MulliganDbContext dbContext) {
            _dbContext = dbContext;
        }

        //Course
        public async Task<List<Course>> GetAllCourses()
        {
            var course = await _dbContext.Course.Include(x => x.CourseHoles).AsTracking().ToListAsync();
            return course;
        }

        public async Task<List<CourseTeeBox>> GetTeeBoxes(Guid courseId)
        {
            var teeBoxes = await _dbContext.TeeBoxes.Where(x => x.CourseId == courseId).ToListAsync();

            return teeBoxes;

        }

        //Hole
        public async Task<CourseHole> GetHoleById(Guid id)
        {
            var hole = await _dbContext.CourseHole.Where(x => x.Id == id).AsNoTracking().FirstOrDefaultAsync();
            return hole;
        }

        public async Task<List<CourseHole>> GetAllHolesForCourse(Guid courseId)
        {
            var holes =  await _dbContext.CourseHole.Include(x => x.Notes).Where(x => x.CourseId == courseId).AsNoTracking().ToListAsync();
            return holes;
        }

        //Round
        public async Task<Round> AddRound(Round round)
        {
            await _dbContext.Round.AddAsync(round);
            return round;
        }

        public async Task<List<Round>> GetAllRoundsForUser(Guid id)
        {
            var rounds = await _dbContext.Round.Include(x => x.Holes).Where(x => x.UserId == id).AsNoTracking().ToListAsync();
            return rounds;
        }

        public async Task<List<Round>> GetAllRounds()
        {
            var rounds =  await _dbContext.Round.Include(x => x.Holes).ToListAsync();
            return rounds;

        }

        //Note
        public async Task<List<Note>> GetAllCourseNotes(Guid userId)
        {
            var notes = await _dbContext.Note.Include(x => x.CourseHole).Where(hole => hole.UserId == userId).ToListAsync();
            return notes;
        }

        public async Task<List<User>> GetAllUsers()
        {
            var users = await _dbContext.User.ToListAsync();
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
            await Save();
        }

        public async Task Save()
        {
            await _dbContext.SaveChangesAsync();
        }




    }
}
