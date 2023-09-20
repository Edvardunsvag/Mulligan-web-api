using MulliganApi.Database.Models;

namespace MulliganApi.Database.Repository
{
    public interface IMulliganRepository
    {
        public Task<List<Course>> GetAllCourses();

        public Task<Round> AddRound(Round round);

        Task Save();

    }
}
