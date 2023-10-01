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
        public async Task<List<Course>> GetAllCourses()
        {
            var course = await _dbContext.Course.Include(x => x.CourseHoles).AsTracking().ToListAsync();
            return course;
        }

        //Round
        public async Task<Round> AddRound(Round round)
        {
            await _dbContext.Round.AddAsync(round);
            return round;
        }

        public async Task<List<Round>> GetAllRoundsForUser(Guid id)
        {
            var rounds = await _dbContext.Round.Include(x => x.Holes).Where(x => x.UserId == id).ToListAsync();
            return rounds;
        }

        public async Task<List<Round>> GetAllRounds()
        {
            var rounds =  await _dbContext.Round.Include(x => x.Holes).ToListAsync();
            return rounds;

        }

        //Note
        public async Task<List<Note>> GetAllNotes(Guid userId)
        {
            var notes = await _dbContext.Note.Include(x => x.CourseHole).Where(x => x.UserId == userId).ToListAsync(); 
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
