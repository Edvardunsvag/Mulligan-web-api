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
        private readonly IMulliganService _service;
        public CourseController(IMulliganService service) {
            _service = service;
        }

        [HttpGet()]
        public  List<CourseInfoDto> GetAllCourses()
        {
            var courseInfo =  _service.GetInfoAboutCourses();
            return courseInfo;
        }

        [HttpGet()]
        public  List<Guid> GetAllCourseIds()
        {
            var courseIds = _service.GetAllCourseIds();
            return courseIds;
        }
    }
}
