using MulliganApi.Database.Models;

namespace MulliganApi.Database.Repository
{
    public interface IMulliganRepository
    {
        public Note GetNoteById(Guid id);
        public Task UpdateNote(Note updatedNote);
        public Task AddNote(Note note);
        public Task DeleteNote(Note note);
        public List<Course> GetAllCourses();
        public Task<Round> AddRound(Round round);
        public CourseHole GetHoleById(Guid holeId);
        public List<User> GetAllUsers();
        public Task AddUser(User user);
        Task Save();
    }
}
