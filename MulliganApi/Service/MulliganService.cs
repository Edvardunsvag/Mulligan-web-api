using MulliganApi.Database.Models;
using MulliganApi.Database.Repository;
using MulliganApi.Dto;
using MulliganApi.Service.Converters;
using MulliganApi.Util;

namespace MulliganApi.Service
{
    public class MulliganService : IMulliganService
    {
        private readonly MulliganRepository _repository;
        private readonly IConverters _converter;
        private readonly IHelperFunctions _helper;
        public MulliganService(MulliganRepository repository, IConverters converters, IHelperFunctions helperFunctions)
        {
            _repository = repository;
            _converter = converters;
            _helper = helperFunctions;
        }

        public List<ScoreBoardRound> GetAllRoundsForScoreBoard()
        {
            var allRounds = _repository.GetAllRounds();
            var courses = _repository.GetAllCourses();
            var allUsers = _repository.GetAllUsers();

            var scoreBoardRoundList = new List<ScoreBoardRound>();
            foreach (var round in allRounds)
            {
                var activeCourse = courses.First(x => x.Id == round.CourseId);
                var user = allUsers.FirstOrDefault(x => x.Id == round.UserId);
                var norwegianFormattedDate = _helper.FormatNorwegianDate(round.Date);
                var formattedScore = _helper.ScoreBasedOnCoursePar(round.Strokes, activeCourse.Par);
                var scoreBoardRound = new ScoreBoardRound()
                {
                    UserId = round.UserId,
                    Score = formattedScore,
                    Strokes = round.Strokes,
                    Date = norwegianFormattedDate,
                    CourseName = activeCourse.CourseName,
                    CourseId = activeCourse.Id,
                    Username = user?.Username,
                    RoundId = round.RoundId
                };
                scoreBoardRoundList.Add(scoreBoardRound);
            }

            return scoreBoardRoundList.OrderBy(x => x.Strokes).ToList();
        }

        public List<ScoreBoardCourseCard>? GetDataForScoreBoard(Guid userId)
        {
            var allRounds = _repository.GetAllRounds();
            var courses = _repository.GetAllCourses();
            var courseCardList = new List<ScoreBoardCourseCard>();
            foreach (var course in courses)
            {
                var numberOfRoundsForCourse = allRounds.Where(x => x.CourseId == course.Id).ToList();
                var userPlacement = GetUserPlacement(numberOfRoundsForCourse, userId);
                if (userPlacement == null)
                {
                    continue;
                }
                var scoreBoardCard = new ScoreBoardCourseCard()
                {
                    CourseName = course.CourseName,
                    CourseId = course.Id,
                    NumberOfRoundsPlayed = $"{numberOfRoundsForCourse.Count} spilte runder",
                    Placement = userPlacement.ToString() ?? "-",
                };
                courseCardList.Add(scoreBoardCard);
            }

            return courseCardList;
        }

        private double? GetUserPlacement(List<Round> allRoundsForCourse, Guid userId)
        {
            var scoresForUser = allRoundsForCourse.Where(x => x.UserId == userId).ToList();
            var sortedAllRounds = allRoundsForCourse.OrderBy(x => x.Strokes).ToList();
            if (scoresForUser.Count == 0)
            {
                return null;
            }
            var bestScoreObject = scoresForUser.FirstOrDefault(x => x.Strokes == scoresForUser.Min(y => y.Strokes));   
            var bestPlacement = sortedAllRounds.IndexOf(bestScoreObject);
            return bestPlacement + 1;
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

        public async Task<Guid> DeleteRound(Guid roundId)
        {
            var round = _repository.GetRound(roundId);
            var deletedRoundId = await _repository.DeleteRound(round);
            return deletedRoundId;
        }

        public List<RoundGetDto> GetAllRoundsForUser(Guid id)
        {
            var rounds =  _repository.GetAllRoundsForUser(id);
            var roundDtoTasks = rounds.Select(x => _converter.ToDto(x)).ToList();
            
            return roundDtoTasks;
        }

        public RoundGetDto GetRound(Guid roundId)
        {
            var round = _repository.GetRound(roundId);
            var roundDto = _converter.ToDto(round);

            return roundDto;
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
        
        public  List<CourseIdAndName> GetAllCourseIds()
        {
            var courses =  _repository.GetAllCourses();
            var courseIds = courses.Select(c => new CourseIdAndName()
            {
                CourseId = c.Id,
                CourseName = c.CourseName
            }).ToList();

            return courseIds;
        }

        public CourseGeneralStats GetCourseGeneralStats(Guid userId, Guid courseId)
        {
            var course = _repository.GetAllCourses().FirstOrDefault(y => y.Id == courseId);
            if (course == null)
            {
                throw new ArgumentException("CourseId Not found", nameof(userId));
            }
            var rounds = _repository.GetAllRoundsForUser(userId).Where(r => r.CourseId == courseId).ToList();
            if (rounds == null || rounds.Count == 0)
            {
                throw new ArgumentException("No rounds for user on this course", nameof(userId));
            }

            var courseStats = GetGeneralCourseStats(course, rounds);
            
            return courseStats;
        }

        public List<CourseRoundHoleStatsDto> GetAllScoresForCourseHole(Guid userId, Guid courseId)
        {
            var course = _repository.GetAllCourses().First(y => y.Id == courseId);
            var rounds = _repository.GetAllRoundsForUser(userId).Where(r => r.CourseId == courseId).ToList();
            if (course == null)
            {
                throw new ArgumentException("CourseId Not found", nameof(userId));
            }
            if (rounds == null || rounds.Count == 0)
            {
                throw new ArgumentException("No rounds for user on this course", nameof(userId));
            }

            var courseStats = GetStatsForEachHole(course, rounds);
            var courseStatsDto = _converter.ToDto(courseStats);
            
            return courseStatsDto;
        }

        private CourseGeneralStats GetGeneralCourseStats(Course course, List<Round> rounds)
        {
            var courseStats = new CourseGeneralStats();

            foreach (var round in rounds)
            {
                foreach (var hole in round.Holes)
                {
                    if (courseStats == null) continue;
                    var score = hole.Score - hole.Par;
                    switch (score)
                    {
                        case <= -3:
                            courseStats.Albatross++;
                            break;
                        case -2:
                            courseStats.Eagle++;
                            break;
                        case -1:
                            courseStats.Birde++;
                            break;
                        case 0:
                            courseStats.Par++;
                            break;
                        case 1:
                            courseStats.Bogey++;
                            break;
                        case 2:
                            courseStats.DoubleBogey++;
                            break;
                        default:
                            courseStats.TrippleBogey++;
                            break;
                    }
                    courseStats.TotalNumberOfHolesPlayed += 1;
                    courseStats.AverageStrokes += hole.Score;
                }
            }
            courseStats.AverageStrokes /= rounds.Count;
            courseStats.AverageScore = Math.Round((double)courseStats.AverageStrokes - course.Par, 1);
            
            courseStats.AverageScoreAsString = courseStats.AverageScore.ToString("F1");
            courseStats.AverageStrokesAsString = courseStats.AverageStrokes.ToString("F1");

            return courseStats;
        }
        
        

        private List<CourseRoundHoleStatsEntityDto> GetStatsForEachHole(Course course, List<Round> rounds)
        {
            var courseStats = new List<CourseRoundHoleStatsEntityDto>();
            for (var holeNumber = 1; holeNumber <= course.CourseHoles.Count; holeNumber++)
            {
                var stats = new CourseRoundHoleStatsEntityDto
                {
                    HoleNumber = holeNumber,
                    HolePar = 0,  
                    AverageScore = 0,
                    AverageScoreAsString = "",
                    Albatross = 0,
                    Eagle = 0,
                    Birde = 0,
                    Par = 0,
                    Bogey = 0,
                    DoubleBogey = 0,
                    TrippleBogey = 0
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
                        switch (score)
                        {
                            case <= -3:
                                stats.Albatross++;
                                break;
                            case -2:
                                stats.Eagle++;
                                break;
                            case -1:
                                stats.Birde++;
                                break;
                            case 0:
                                stats.Par++;
                                break;
                            case 1:
                                stats.Bogey++;
                                break;
                            case 2:
                                stats.DoubleBogey++;
                                break;
                            default:
                                stats.TrippleBogey++;
                                break;
                        }
                        stats.HolePar = hole.Par;
                    }
                    stats.AverageScore += hole.Score;
                }
            }
            
            foreach (var stats in courseStats)
            {
                stats.AverageScore /= rounds.Count;
                stats.AverageScoreAsString = stats.AverageScore.ToString("F1");
            }

            return courseStats;
        }
    }
}
