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
        private readonly IMulliganService _iMulliganService;
        public CourseController(IMulliganService iMulliganService) {
            _iMulliganService = iMulliganService;
        }

        [HttpGet()]
        public  List<CourseInfoDto> GetAllCourses()
        {
            var courseInfo =  _iMulliganService.GetInfoAboutCourses();
            return courseInfo;
        }

        [HttpGet()]
        public List<CourseIdAndName> GetAllCourseIds()
        {
            var courseIds = _iMulliganService.GetAllCourseIds();
            return courseIds;
        }

        [HttpGet]
        public List<CourseRoundHoleStatsDto> GetAllScoresForCourseHoles(Guid userId, Guid courseId)
        {
            var courseRounds = _iMulliganService.GetAllScoresForCourseHole(userId,courseId);
            return courseRounds;
        }

        [HttpGet]
        public CourseGeneralStats GetCourseGeneralStats(Guid userId, Guid courseId)
        {
            var courseRounds = _iMulliganService.GetCourseGeneralStats(userId,courseId);
            return courseRounds;
        }
        
        [HttpGet]
        public List<ScoreBoardRound> GetAllRoundsForCourse(Guid courseId)
        {
            var courseRounds = _iMulliganService.GetAllRoundsForCourse(courseId);
            return courseRounds;
        }
    }
}
