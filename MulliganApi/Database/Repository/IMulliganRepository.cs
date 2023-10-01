using MulliganApi.Database.Models;

namespace MulliganApi.Database.Repository
{
    public interface IMulliganRepository
    {
        public Task<List<Course>> GetAllCourses();

        public Task<Round> AddRound(Round round);

        public Task<List<User>> GetAllUsers();
        public Task AddUser(User user);

        public Task AddNote(Note note);
        Task Save();
    }
}
