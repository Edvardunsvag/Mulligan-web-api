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

        public  List<CourseInfoDto> GetInfoAboutCourses()
        {
            var courses =  _repository.GetAllCourses();
            var courseList = new List<CourseInfoDto>();
            foreach (var course in courses)
            {
                var teeBoxes =  _repository.GetTeeBoxes(course.Id);
                courseList.Add(_converter.ToDto(course, teeBoxes));
            }

            return courseList;
        }

        public async Task<Round> AddRound(RoundPostDto dto)
        {
            var courses =  _repository.GetAllCourses();
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
                Par = hole.Par
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
            
            await _repository.AddRound(round);
            await _repository.Save();
                
            return round;
        }

        public List<RoundGetDto> GetAllRoundsForUser(Guid id)
        {
            var rounds =  _repository.GetAllRoundsForUser(id);
            var roundDtoTasks = rounds.Select(x => _converter.ToDto(x)).ToList();
            
            return roundDtoTasks;
        }

        public List<RoundGetDto> GetAllRounds()
        {
            var rounds = _repository.GetAllRounds();
            var roundDto = rounds.Select(x => _converter.ToDto(x)).ToList();

            return roundDto;
        }

        public  List<CourseNoteDto> GetAllNotesForUser(Guid userId)
        {
            if (userId == Guid.Empty)
                throw new ArgumentException("User ID cannot be empty.", nameof(userId));
            var notes =  _repository.GetAllCourseNotes(userId);
            var courses =  _repository.GetAllCourses();
            var notesDtos = courses.Select(course => _converter.ToDto(notes, course, userId)).ToList();

            return notesDtos;
        }
        
        public  CourseNoteDto GetAllNotesForCourse(Guid userId, Guid courseId)
        {
            if (userId == Guid.Empty)
                throw new ArgumentException("User ID cannot be empty.", nameof(userId));
            var notes =  _repository.GetAllCourseNotes(userId);
            var courses =  _repository.GetAllCourses();
            var courseNotes = courses.First(course => course.Id == courseId);
            var courseNotesDto = _converter.ToDto(notes, courseNotes, userId);

            return courseNotesDto;
        }
        
        public  List<Guid> GetAllCourseIds()
        {
            var courses =  _repository.GetAllCourses();
            var courseIds = courses.Select(c => c.Id).ToList();

            return courseIds;
        }

        public CourseGeneralStats GetCourseGeneralStats(Guid userId, Guid courseId)
        {
            var courseStats = new CourseGeneralStats();
            var course = _repository.GetAllCourses().First(y => y.Id == courseId);
            var rounds = _repository.GetAllRoundsForUser(userId).Where(r => r.CourseId == courseId).ToList();
            foreach (var round in rounds)
            {
                foreach (var hole in round.Holes)
                {
                    if (courseStats != null)
                    {
                        var score = hole.Score - hole.Par;
                        if (score == -2)
                        {
                            courseStats.Eagle++;
                        }
                        else if (score == -1)
                        {
                            courseStats.Birde++;
                        }
                        else if (score == 0)
                        {
                            courseStats.Par++;
                        }
                        else if (score == 1)
                        {
                            courseStats.Bogey++;
                        }
                        else if (score == 2)
                        {
                            courseStats.DoubleBogey++;
                        }
                        courseStats.TotalNumberOfHolesPlayed += 1;
                        courseStats.AverageStrokes += hole.Score;
                    }
                }
            }
            courseStats.AverageStrokes = courseStats.AverageStrokes / rounds.Count;
            
            return courseStats;
        }

        public List<CourseRoundHoleStatsDto> GetAllScoresForCourseHole(Guid userId, Guid courseId)
        {
            var courseStats = new List<CourseRoundHoleStatsDto>();
            var course = _repository.GetAllCourses().First(y => y.Id == courseId);
            var rounds = _repository.GetAllRoundsForUser(userId).Where(r => r.CourseId == courseId).ToList();

            // Initialize statistics for each hole
            for (var holeNumber = 1; holeNumber <= course.CourseHoles.Count; holeNumber++)
            {
                var stats = new CourseRoundHoleStatsDto
                {
                    HoleNumber = holeNumber,
                    HolePar = 0,  
                    AverageScore = 0,
                    Eagle = 0,
                    Birde = 0,
                    Par = 0,
                    Bogey = 0,
                    DoubleBogey = 0
                };
                
                courseStats.Add(stats);
            }

            foreach (var round in rounds)
            {
                
                foreach (var hole in round.Holes)
                {
                    var stats = courseStats.Find(stat => stat.HoleNumber == hole.HoleNumber);

                    if (stats != null)
                    {
                        var score = hole.Score - hole.Par;
                        if (score == -2)
                        {
                            stats.Eagle++;
                        }
                        else if (score == -1)
                        {
                            stats.Birde++;
                        }
                        else if (score == 0)
                        {
                            stats.Par++;
                        }
                        else if (score == 1)
                        {
                            stats.Bogey++;
                        }
                        else if (score == 2)
                        {
                            stats.DoubleBogey++;
                        }
                        stats.HolePar = hole.Par;
                    }
                    stats.AverageScore += hole.Score;
                }
            }
            
            foreach (var stats in courseStats)
            {
                stats.AverageScore /= rounds.Count;
            }
  
            return courseStats;
        }
    }
}
