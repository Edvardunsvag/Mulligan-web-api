using MulliganApi.Database.Models;
using MulliganApi.Dto;

namespace MulliganApi.Service
{
    public interface IMulliganService
    {
        //Course
        List<CourseInfoDto> GetInfoAboutCourses();
        List<Guid> GetAllCourseIds();

        //Rounds
        List<RoundGetDto> GetAllRoundsForUser(Guid id);
        List<RoundGetDto> GetAllRounds();
        Task<Round> AddRound(RoundPostDto round);

        //Notes
        List<CourseNoteDto> GetAllNotesForUser(Guid userId);
        CourseNoteDto GetAllNotesForCourse(Guid userId, Guid courseId);

    }
}
