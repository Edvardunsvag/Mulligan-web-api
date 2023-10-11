using MulliganApi.Database.Models;
using MulliganApi.Database.Repository;
using MulliganApi.Dto;

namespace MulliganApi.Service
{
    public class MulliganService : IMulliganService
    {
        private readonly MulliganRepository _repository;
        public MulliganService(MulliganRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<CourseInfoDto>> GetInfoAboutCourses()
        {
            var courses = await _repository.GetAllCourses();
            var courseList = new List<CourseInfoDto>();
            foreach (var course in courses)
            {
                var teeBoxes = await _repository.GetTeeBoxes(course.Id);
                courseList.Add(ToDto(course, teeBoxes));
            }

            return courseList;
        }

        public async Task<Round> AddRound(RoundPostDto dto)
        {
            var roundId = Guid.NewGuid();
            var roundHoles = dto.RoundHoles.Select((hole, index) => new RoundHole
            {
                HoleNumber = hole.HoleNumber,
                Id = Guid.NewGuid(),
                RoundId = roundId,
                Score = hole.Score,
                Puts = hole.Puts,
            }).ToList();

            var totalStrokes = roundHoles.Select(x => x.Score).Sum();
            var totalPuts = roundHoles.Select(x => x.Puts).Sum();
            var round = new Round
            {
                RoundId = roundId,
                Strokes = totalStrokes,
                UserId = dto.UserId,
                Holes = roundHoles,
                CourseId = dto.CourseId,
                Puts = totalPuts
            };

            try
            {
                await _repository.AddRound(round);
                await _repository.Save();
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log the error)
                throw new Exception("An error occurred while adding the round.", ex);
            }

            return round;
        }

        public async Task<List<RoundGetDto>> GetAllRoundsForUser(Guid id)
        {
            var rounds = await _repository.GetAllRoundsForUser(id);
            var roundsDto = rounds.Select(x => ToDto(x)).ToList();

            return roundsDto;
        }

        public async Task<List<RoundGetDto>> GetAllRounds()
        {
            var rounds = await _repository.GetAllRounds();
            var roundsDto = rounds.Select(x => ToDto(x)).ToList();

            return roundsDto;
        }

        public async Task<List<Task<CourseNoteDto>>> GetAllNotesForUser(Guid userid)
        {
            var notes = await _repository.GetAllCourseNotes(userid).ConfigureAwait(false);
            var courses = await _repository.GetAllCourses().ConfigureAwait(false);
            var notesDtos = courses.Select(course => ToDtoAsync(notes, course)).ToList();

            return notesDtos;
        }

        public class CourseHoleNoteDto
        {
            public string HoleName { get; set; }
            public List<string> Notes { get; set; }
        }

        public async Task<CourseNoteDto> ToDtoAsync(List<Note> notes, Course course)
        {
            var notesForCourse = notes.Where(x => x.CourseHole.CourseId == course.Id);
            var holeNotesWithEmptyContentCount = notesForCourse.Where(holeNote => holeNote.NoteText != "").Count();
            var numberOfHolesWithNotes = $"{holeNotesWithEmptyContentCount}/9";

            var allHolesForCourse = await _repository.GetAllHolesForCourse(course.Id);
            var notesForAllHoles = allHolesForCourse.Select(x => new CourseHoleNoteDto()
            {
                HoleName = $"Hull {x.HoleNumber}",
                Notes = x.Notes?.Select(x => x.NoteText).ToList(),

            }).ToList();

            var noteDto = new CourseNoteDto()
            {
                NumberOfHolesWithNotes = numberOfHolesWithNotes,
                CourseName = course.CourseName,
                NotesForAllHoles = notesForAllHoles.OrderBy(x => x.HoleName).ToList(),
            };

           return noteDto;
        }


        public RoundGetDto ToDto(Round round)
        {
            var roundDto = new RoundGetDto()
            {
                CourseId = round.CourseId,
                Strokes = round.Strokes,
                Puts = round.Puts,
                Holes = round.Holes.Select(x => new RoundHoleDto()
                {
                    HoleNumber = x.HoleNumber,
                    Score = x.Score,
                    Puts = x.Puts,
                }).ToList(),
            };

            return roundDto;
        }



        public CourseInfoDto ToDto(Course course, List<CourseTeeBox> teeBoxes)
        {
            var courseInfo = new CourseInfoDto()
            {
                CourseDescription = course.CourseDescription,
                CourseName = course.CourseName,
                TeeBoxes = teeBoxes.Select(x => (int)x.TeeBox).ToList(),
                Has18Holes = false,
                Length = course.Length
        };

            return courseInfo;
        }

        public async Task<List<Guid>> GetAllCourseIds()
        {
            var courses = await _repository.GetAllCourses();
            var courseIds = courses.Select(c => c.Id).ToList();

            return courseIds;
        }
    }
}
