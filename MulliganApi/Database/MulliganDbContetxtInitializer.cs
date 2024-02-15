using Microsoft.EntityFrameworkCore;
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
            var krokholId = Guid.NewGuid();
            var gronmoId = Guid.NewGuid();
            CourseInitialization(krokholId);
            CourseInitializationGronmo(gronmoId);
        }

        private void CourseInitialization(Guid courseId)
        {
            var emptyNoteList = new List<Note>();
            var courseHoles = new List<CourseHole>
            {
                new CourseHole {Id = Guid.NewGuid(), Par = 3, HoleNumber = 1, CourseId = courseId, Length = 113, Notes = emptyNoteList},
                new CourseHole {Id = Guid.NewGuid(), Par = 4, HoleNumber = 2, CourseId = courseId, Length = 295, Notes = emptyNoteList},
                new CourseHole {Id = Guid.NewGuid(), Par = 5, HoleNumber = 3, CourseId = courseId, Length = 439, Notes = emptyNoteList },
                new CourseHole {Id = Guid.NewGuid(), Par = 3, HoleNumber = 4, CourseId = courseId, Length = 128, Notes = emptyNoteList},
                new CourseHole {Id = Guid.NewGuid(), Par = 5, HoleNumber = 5, CourseId = courseId, Length = 506, Notes = emptyNoteList },
                new CourseHole {Id = Guid.NewGuid(), Par = 4, HoleNumber = 6, CourseId = courseId, Length = 227, Notes = emptyNoteList },
                new CourseHole {Id = Guid.NewGuid(), Par = 4, HoleNumber = 7, CourseId = courseId, Length = 270, Notes = emptyNoteList },
                new CourseHole {Id = Guid.NewGuid(), Par = 4, HoleNumber = 8, CourseId = courseId, Length = 298, Notes = emptyNoteList },
                new CourseHole {Id = Guid.NewGuid(), Par = 4, HoleNumber = 9, CourseId = courseId, Length = 330, Notes = emptyNoteList},
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
                CourseName = "Krokhol golfklubb",
                CourseDescription = "Krokhol golfklubb description",
                Has18Holes = false,
                Length = courseHoles.Select(x => x.Length).Sum(),
                Par = 36,
            };
            
            // Add Course and CourseHoles to the context
            _builder.Entity<CourseTeeBox>().HasData(courseTeeBox);
            _builder.Entity<Course>().HasData(course);
            _builder.Entity<CourseHole>().HasData(courseHoles);
        }

        private void CourseInitializationGronmo(Guid courseId)
        {
            var emptyNoteList = new List<Note>();
            var courseHoles = new List<CourseHole>
            {
                new CourseHole {Id = Guid.NewGuid(), Par = 5, HoleNumber = 1, CourseId = courseId, Length = 494, Notes = emptyNoteList},
                new CourseHole {Id = Guid.NewGuid(), Par = 5, HoleNumber = 2, CourseId = courseId, Length = 266, Notes = emptyNoteList},
                new CourseHole {Id = Guid.NewGuid(), Par = 4, HoleNumber = 3, CourseId = courseId, Length = 361, Notes = emptyNoteList },
                new CourseHole {Id = Guid.NewGuid(), Par = 4, HoleNumber = 4, CourseId = courseId, Length = 367, Notes = emptyNoteList},
                new CourseHole {Id = Guid.NewGuid(), Par = 3, HoleNumber = 5, CourseId = courseId, Length = 127, Notes = emptyNoteList },
                new CourseHole {Id = Guid.NewGuid(), Par = 4, HoleNumber = 6, CourseId = courseId, Length = 337, Notes = emptyNoteList },
                new CourseHole {Id = Guid.NewGuid(), Par = 5, HoleNumber = 7, CourseId = courseId, Length = 412, Notes = emptyNoteList },
                new CourseHole {Id = Guid.NewGuid(), Par = 3, HoleNumber = 8, CourseId = courseId, Length = 141, Notes = emptyNoteList },
                new CourseHole {Id = Guid.NewGuid(), Par = 4, HoleNumber = 9, CourseId = courseId, Length = 365, Notes = emptyNoteList},
            };

            var courseTeeBox = new CourseTeeBox
            {
                Id = Guid.NewGuid(),
                CourseId = courseId,
                TeeBox = TeeBoxEnum.Tee57  // Associate the TeeBoxEnum
            };

            // Create Course entity and associate it with CourseHoles
            var course = new Course
            {
                Id = courseId,
                CourseName = "Grønmo golfklubb",
                CourseDescription = "Grønmo golfklubb description",
                Has18Holes = false,
                Length = courseHoles.Select(x => x.Length).Sum(),
                Par = 37,
            };
            
            // Add Course and CourseHoles to the context
            _builder.Entity<CourseTeeBox>().HasData(courseTeeBox);
            _builder.Entity<Course>().HasData(course);
            _builder.Entity<CourseHole>().HasData(courseHoles);
        }

      
    }
}
