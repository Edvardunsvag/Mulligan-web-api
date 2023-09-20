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

        public async Task Save()
        {
            await _dbContext.SaveChangesAsync();
        }


    }
}
