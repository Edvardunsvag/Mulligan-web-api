using MulliganApi.Database.Models;

namespace MulliganApi.Database.Repository
{
    public interface IMulliganRepository
    {
        public List<Course> GetAllCourses();
        public Task<Round> AddRound(Round round);
        public List<User> GetAllUsers();
        public Task AddUser(User user);
        public Task AddNote(Note note);
        public CourseHole GetHoleById(Guid holeId);
        Task Save();
    }
}
