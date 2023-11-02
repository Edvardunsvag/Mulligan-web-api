﻿using Microsoft.AspNetCore.Mvc;
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
        public  List<CourseInfoDto> GetAllCourses()
        {
            var courseInfo =  _service.GetInfoAboutCourses();
            return courseInfo;
        }

        [HttpGet()]
        public List<Guid> GetAllCourseIds()
        {
            var courseIds = _service.GetAllCourseIds();
            return courseIds;
        }

        [HttpGet]
        public List<CourseRoundHoleStatsDto> GetAllScoresForCourseHoles(Guid userId, Guid courseId)
        {
            var courseRounds = _service.GetAllScoresForCourseHole(userId,courseId);
            return courseRounds;
        }

        [HttpGet]
        public CourseGeneralStats GetCourseGeneralStats(Guid userId, Guid courseId)
        {
            var courseRounds = _service.GetCourseGeneralStats(userId,courseId);
            return courseRounds;
        }
    }
}
