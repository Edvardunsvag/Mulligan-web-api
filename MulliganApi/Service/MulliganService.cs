using MulliganApi.Database.Models;
using MulliganApi.Database.Repository;
using MulliganApi.Dto;
using MulliganApi.Service.Converters;

namespace MulliganApi.Service
{
    public class MulliganService : IMulliganService
    {
        private readonly MulliganRepository _repository;
        private readonly IConverters _converter;
        public MulliganService(MulliganRepository repository, IConverters converters)
        {
            _repository = repository;
            _converter = converters;
        }

        public async Task<List<CourseInfoDto>> GetInfoAboutCourses()
        {
            var courses = await _repository.GetAllCourses();
            var courseList = new List<CourseInfoDto>();
            foreach (var course in courses)
            {
                var teeBoxes = await _repository.GetTeeBoxes(course.Id);
                courseList.Add(_converter.ToDto(course, teeBoxes));
            }

            return courseList;
        }

        public async Task<Round> AddRound(RoundPostDto dto)
        {
            var courses = await _repository.GetAllCourses();
            var correctCourseIdInDto = courses.FirstOrDefault(x => x.Id == dto.CourseId);
            if (correctCourseIdInDto == null)
            {
                throw new Exception("Course ID added by user is not correct.");
            }
         
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
                Puts = totalPuts,
                Date = DateTime.Now,
            };

            try
            {
                await _repository.AddRound(round);
                await _repository.Save();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding the round.", ex);
            }

            return round;
        }

        public async Task<List<RoundGetDto>> GetAllRoundsForUser(Guid id)
        {
            var rounds = await _repository.GetAllRoundsForUser(id);
            var roundDtoTasks = rounds.Select(async x => await _converter.ToDto(x));
            var roundDtos = await Task.WhenAll(roundDtoTasks);

            return roundDtos.ToList();
        }

        public async Task<List<RoundGetDto>> GetAllRounds()
        {
            var rounds = await _repository.GetAllRounds();
            var roundDtoTasks = rounds.Select(x => _converter.ToDto(x));
            var roundDtos = await Task.WhenAll(roundDtoTasks);

            return roundDtos.ToList();
        }

        public async Task<List<CourseNoteDto>> GetAllNotesForUser(Guid userId)
        {
            if (userId == Guid.Empty)
                throw new ArgumentException("User ID cannot be empty.", nameof(userId));
            var notes = await _repository.GetAllCourseNotes(userId).ConfigureAwait(false);
            var courses = await _repository.GetAllCourses().ConfigureAwait(false);
            var notesDtos = courses.Select(course => _converter.ToDtoAsync(notes, course, userId).Result).ToList();

            return notesDtos;
        }
        
        public async Task<List<Guid>> GetAllCourseIds()
        {
            var courses = await _repository.GetAllCourses();
            var courseIds = courses.Select(c => c.Id).ToList();

            return courseIds;
        }
    }
}
