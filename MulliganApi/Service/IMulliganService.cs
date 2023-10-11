using MulliganApi.Database.Models;
using MulliganApi.Dto;

namespace MulliganApi.Service
{
    public interface IMulliganService
    {
        //Course
        Task<List<CourseInfoDto>> GetInfoAboutCourses();
        Task<List<Guid>> GetAllCourseIds();

        //Rounds
        Task<List<RoundGetDto>> GetAllRoundsForUser(Guid id);
        Task<List<RoundGetDto>> GetAllRounds();
        Task<Round> AddRound(RoundPostDto round);

        //Notes
        Task<List<Task<CourseNoteDto>>> GetAllNotesForUser(Guid userId);
    }
}
