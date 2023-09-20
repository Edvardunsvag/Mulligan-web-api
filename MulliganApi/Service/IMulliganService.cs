using MulliganApi.Database.Models;
using MulliganApi.Dto;

namespace MulliganApi.Service
{
    public interface IMulliganService
    {
        Task<List<CourseInfoDto>> GetInfoAboutCourses();

        Task<Round> AddRound(RoundPostDto round);

        Task<List<Guid>> GetAllCourseIds();

        Task<List<RoundGetDto>> GetAllRoundsForUser(Guid id);
    }
}
