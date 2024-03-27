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
        Task<Guid> DeleteRound(Round round);
        List<Round> GetAllRoundsForUser(Guid userId);
        List<Round>? GetAllRounds();
        
        //COURSE
        public CourseHole GetHoleById(Guid holeId);
        public List<Course> GetAllCourses();
        
        //USERS
        public List<User> GetAllUsers();
        public Task AddUser(User user);
        public Task<User> DeleteUser(User user);
        public Task AddUserRating(UserRatings userRating);
        public Task<List<UserRatings>> GetAllUserRatings();
        public Task UpdateUser(User user);
        public Task AddAdminRoleToUser(UserRole adminRole, User user);
        Task Save();
    }
}
