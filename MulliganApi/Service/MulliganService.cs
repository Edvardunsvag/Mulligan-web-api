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
            var roundHoles = new List<RoundHole>();
            var roundId = Guid.NewGuid();
            dto.RoundHoles.Select((hole, index) => new RoundHole()
            {
                HoleNumber = hole.HoleNumber,
                Id = Guid.NewGuid(),
                RoundId = roundId,
                Score = hole.Score
            });
            var round = new Round()
            {
                RoundId = roundId,
                Strokes = dto.Strokes,
                UserId = dto.UserId,
                Holes = roundHoles,
                CourseId = dto.CourseId
            };

            await _repository.AddRound(round);
            await _repository.Save();

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

        public async Task<List<CourseNoteDto>> GetAllNotesForUser(Guid userid)
        {
            var notes = await _repository.GetAllCourseNotes(userid).ConfigureAwait(false);
            var courses = await _repository.GetAllCourses().ConfigureAwait(false);
            var notesDtos = courses.Select(course => ToDtoAsync(notes, course)).ToList();

            return notesDtos;
        }

        public CourseNoteDto ToDtoAsync(List<Note> notes, Course course)
        {
            var notesForCourse = notes.Where(x => x.CourseHole.CourseId == course.Id);

            var holeNotesWithEmptyContentCount = notesForCourse
                .Where(holeNote => holeNote.NoteText != "").Count();
            string output = $"NumberOfHolesWithNotes = {holeNotesWithEmptyContentCount}/9";

            var noteDto = new CourseNoteDto()
            {
                NumberOfHolesWithNotes = output,
                CourseName = course.CourseName
            };

           return noteDto;
        }


        public RoundGetDto ToDto(Round round)
        {
            var roundDto = new RoundGetDto()
            {
                CourseId = round.CourseId,
                Strokes = round.Strokes,
                Holes = round.Holes.Select(x => new RoundHoleDto()
                {
                    HoleNumber = x.HoleNumber,
                    Score = x.Score,
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
                TeeBoxes = teeBoxes.Select(x => (int)x.TeeBox).ToList()
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
