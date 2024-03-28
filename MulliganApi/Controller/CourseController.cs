using Microsoft.AspNetCore.Mvc;
using MulliganApi.Authentication;
using MulliganApi.Dto;
using MulliganApi.Service;

namespace MulliganApi.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [ServiceFilter(typeof(ApiKeyAuthFilter))]
    public class CourseController
    {
        private readonly IMulliganService _mulliganService;
        public CourseController(IMulliganService mulliganService) {
            _mulliganService = mulliganService;
        }

        [HttpGet()]
        public  List<CourseInfoDto> GetAllCourses()
        {
            var courseInfo =  _mulliganService.GetInfoAboutCourses();
            return courseInfo;
        }

        [HttpGet()]
        public List<CourseIdAndName> GetAllCourseIds()
        {
            var courseIds = _mulliganService.GetAllCourseIds();
            return courseIds;
        }

        [HttpGet]
        public List<CourseRoundHoleStatsDto> GetAllScoresForCourseHoles(Guid userId, Guid courseId)
        {
            var courseRounds = _mulliganService.GetAllScoresForCourseHole(userId,courseId);
            return courseRounds;
        }

        [HttpGet]
        public CourseGeneralStats GetCourseGeneralStats(Guid userId, Guid courseId)
        {
            var courseRounds = _mulliganService.GetCourseGeneralStats(userId,courseId);
            return courseRounds;
        }
    }
}
