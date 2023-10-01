﻿using Microsoft.EntityFrameworkCore;
using MulliganApi.Database.Enums;
using MulliganApi.Database.Models;
using System.Reflection.Emit;

namespace MulliganApi.Database
{
    public class MulliganDbContetxtInitializer  
    {
        private readonly ModelBuilder _builder;

        public MulliganDbContetxtInitializer(ModelBuilder builder)
        {
            _builder = builder;
        }

        public void Seed()
        {
            var courseId = Guid.NewGuid();
            CourseInitialization(courseId);
            RoundInitialization(courseId);
        }

        public void CourseInitialization(Guid courseId)
        {

            var courseHoles = new List<CourseHole>
            {
                new CourseHole {Id = Guid.NewGuid(), Par = 3, HoleNumber = 1, CourseId = courseId, Length = 113},
                new CourseHole {Id = Guid.NewGuid(), Par = 4, HoleNumber = 2, CourseId = courseId, Length = 295 },
                new CourseHole {Id = Guid.NewGuid(), Par = 5, HoleNumber = 3, CourseId = courseId, Length = 439 },
                new CourseHole {Id = Guid.NewGuid(), Par = 3, HoleNumber = 4, CourseId = courseId, Length = 128 },
                new CourseHole {Id = Guid.NewGuid(), Par = 5, HoleNumber = 5, CourseId = courseId, Length = 506 },
                new CourseHole {Id = Guid.NewGuid(), Par = 4, HoleNumber = 6, CourseId = courseId, Length = 227 },
                new CourseHole {Id = Guid.NewGuid(), Par = 4, HoleNumber = 7, CourseId = courseId, Length = 270 },
                new CourseHole {Id = Guid.NewGuid(), Par = 4, HoleNumber = 8, CourseId = courseId, Length = 298 },
                new CourseHole {Id = Guid.NewGuid(), Par = 4, HoleNumber = 9, CourseId = courseId, Length = 330},
            };

            var courseTeeBox = new CourseTeeBox
            {
                Id = Guid.NewGuid(),
                CourseId = courseId,
                TeeBox = TeeBoxEnum.Tee52  // Associate the TeeBoxEnum
            };

            // Create Course entity and associate it with CourseHoles
            var course = new Course
            {
                Id = courseId,
                CourseName = "Krokhol",
                CourseDescription = "Krokhol golfklubb description",
            };


            // Add Course and CourseHoles to the context
            _builder.Entity<CourseTeeBox>().HasData(courseTeeBox);
            _builder.Entity<Course>().HasData(course);
            _builder.Entity<CourseHole>().HasData(courseHoles);

        }

        public void RoundInitialization(Guid courseId)
        {
            var roundId = Guid.NewGuid();
            var round = new Round()
            {
                CourseId = courseId,
                Strokes = 45,
                RoundId = roundId,
                UserId = Guid.NewGuid(),
            };

            var roundHoles = new List<RoundHole>()
            {
                new RoundHole()
                {
                    HoleNumber = 1,
                    Id = Guid.NewGuid(),
                    RoundId = roundId,
                    Score = 2
                },
                 new RoundHole()
                {
                    HoleNumber = 2,
                    Id = Guid.NewGuid(),
                    RoundId = roundId,
                    Score = 6
                },
                  new RoundHole()
                {
                    HoleNumber = 3,
                    Id = Guid.NewGuid(),
                    RoundId = roundId,
                    Score = 3
                },
                   new RoundHole()
                {
                    HoleNumber = 4,
                    Id = Guid.NewGuid(),
                    RoundId = roundId,
                    Score = 3
                },
                    new RoundHole()
                {
                    HoleNumber = 5,
                    Id = Guid.NewGuid(),
                    RoundId = roundId,
                    Score = 4
                },
                     new RoundHole()
                {
                    HoleNumber = 6,
                    Id = Guid.NewGuid(),
                    RoundId = roundId,
                    Score = 4
                },
                      new RoundHole()
                {
                    HoleNumber = 7,
                    Id = Guid.NewGuid(),
                    RoundId = roundId,
                    Score = 5
                },
                       new RoundHole()
                {
                    HoleNumber = 8,
                    Id = Guid.NewGuid(),
                    RoundId = roundId,
                    Score = 2
                },
                        new RoundHole()
                {
                    HoleNumber = 9,
                    Id = Guid.NewGuid(),
                    RoundId = roundId,
                    Score = 4
                },
            };

            //Add to tables
            _builder.Entity<RoundHole>().HasData(roundHoles);
            _builder.Entity<Round>().HasData(round);

        }
    }
}
