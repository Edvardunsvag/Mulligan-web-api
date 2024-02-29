using MulliganApi.Database.Enums;
using MulliganApi.Database.Models;

namespace MulliganApi.Database.Repository
{
    public interface IMulliganRepository
    {
        //NOTE
        public Note GetNoteById(Guid id);
        public Task UpdateNote(Note updatedNote);
        public Task AddNote(Note note);
        public Task DeleteNote(Note note);
        
        //ROUNDS
        public Task<Round> AddRound(Round round);
        Round GetRound(Guid roundId);
        
        //COURSE
        public CourseHole GetHoleById(Guid holeId);
        public List<Course> GetAllCourses();
        public List<User> GetAllUsers();
        public Task AddUser(User user);
        public Task AddUserRating(UserRatings userRating);
        public Task<List<UserRatings>> GetAllUserRatings();
        public Task UpdateUser(User user);
        public Task AddAdminRoleToUser(UserRole adminRole, User user);
        Task Save();
    }
}
