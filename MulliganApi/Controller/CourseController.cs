using Microsoft.AspNetCore.Mvc;
using MulliganApi.Dto;
using MulliganApi.Service;

namespace MulliganApi.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CourseController
    {
        private readonly IMulliganService _service;
        public CourseController(IMulliganService service) {
            _service = service;
        }

        [HttpGet()]
        public async Task<List<CourseInfoDto>> GetAllCourses()
        {
            var courseInfo = await _service.GetInfoAboutCourses();
            return courseInfo;
        }

        [HttpGet()]
        public async Task<List<Guid>> GetAllCourseIds()
        {
            var courseIds = await _service.GetAllCourseIds();
            return courseIds;
        }
    }
}
