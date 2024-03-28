using System.Globalization;
using MulliganApi.Database.Models;
using MulliganApi.Database.Repository;
using MulliganApi.Dto;
using MulliganApi.Util;

namespace MulliganApi.Service.Converters;

public interface IConverters
{
    RoundGetDto ToDto(Round round);
    CourseInfoDto ToDto(Course course, List<CourseTeeBox> teeBoxes);
    CourseNoteDto ToDto(List<Note> notes, Course course, Guid userId);
    List<CourseRoundHoleStatsDto> ToDto(List<CourseRoundHoleStatsEntityDto> courseStatsEntity);
    

}

public class Converters : IConverters
{
    private readonly MulliganRepository _repository;
    private readonly IHelperFunctions _helper;

    public Converters(MulliganRepository repository, IHelperFunctions helper)
    {
        _repository = repository;
        _helper = helper;
    }

    private static string FromScoreToString(int score, int par)
    {
        if (score == par)
        {
            return "Par";
        }
        if (score == par - 3)
        {
            return "Albatross";
        }
        if (score == par - 1)
        {
            return "Birdie";
        }
        if (score == par - 2)
        {
            return "Eagle";
        }
        if (score == par +1)
        {
            return "Bogey";
        }
        if (score == par +2)
        {
            return "Dobbel Bogey";
        }
        return score >= par +3 ? "Tripple Bogey" : "";
    }
    
    public RoundGetDto ToDto(Round round)
    {
        var courses =  _repository.GetAllCourses();
        var connectedCourse = courses.FirstOrDefault(x => x.Id == round.CourseId);
        var norwegianDate = _helper.FormatNorwegianDate(round.Date);
        var scoreAccordingToPar = _helper.ScoreBasedOnCoursePar(round.Strokes, connectedCourse.Par);

        var holeStats = new List<HoleGeneralStats>();
        var totalNumberOfHoles = 0;
        foreach (var hole in round.Holes)
        {
            var scoreName = FromScoreToString(hole.Score, hole.Par);
            var existingHoleStat = holeStats.FirstOrDefault(hs => hs.ScoreName == scoreName);

            if (existingHoleStat != null)
            {
                existingHoleStat.ScoreAmount++;
            }
            else
            {
                var holeStat = new HoleGeneralStats()
                {
                    ScoreName = scoreName,
                    ScoreAmount = 1,
                    Percentage = 0,
                };
                holeStats.Add(holeStat);
            }

            totalNumberOfHoles++;
        }
        foreach (var holeStat in holeStats)
        {
            var rawPercentage = ((double)holeStat.ScoreAmount / totalNumberOfHoles) * 100;
            holeStat.Percentage = Math.Round(rawPercentage, 0);
            holeStat.PercentageAsString = holeStat.Percentage.ToString(CultureInfo.InvariantCulture);
        }
        
        var roundDto = new RoundGetDto()
        {
            CourseId = round.CourseId,
            RoundId = round.RoundId,
            Strokes = round.Strokes,
            ScoreAccordingToPar = scoreAccordingToPar,
            CoursePar = connectedCourse.Par,
            Puts = round.Puts,
            NorwegianDate = norwegianDate,
            Date = round.Date,
            CourseName = connectedCourse.CourseName,
            GeneralDescription = "Et par timer til på rangen så nærmer du deg Simon sitt nivå!",
            HoleStats = holeStats,
            Holes = round.Holes.Select(x => new RoundHoleDto()
            {
                HoleNumber = x.HoleNumber,
                Score = x.Score,
                Puts = x.Puts,
                Par = connectedCourse.CourseHoles.First(h => h.HoleNumber == x.HoleNumber).Par
            }).OrderBy(x => x.HoleNumber).ToList()
        };

        return roundDto;
    }
    
    public CourseInfoDto ToDto(Course course, List<CourseTeeBox> teeBoxes)
    {
        var courseInfo = new CourseInfoDto()
        {
            CourseId = course.Id,
            CourseDescription = course.CourseDescription,
            CourseName = course.CourseName,
            TeeBoxes = teeBoxes.Select(x => (int)x.TeeBox).ToList(),
            Has18Holes = false,
            Length = course.Length,
            TotalPar =  course.CourseHoles.Sum(x => x.Par),
            Holes = course.CourseHoles.Select(x => new CourseHoleDto()
            {
                HoleNumber = x.HoleNumber,
                Par = x.Par,
                HoleId = x.Id,
                Score = x.Par,
                Puts = 2,
                Length = x.Length
            }).OrderBy(x => x.HoleNumber).ToList(),
        };

        return courseInfo;
    }
    
    public  CourseNoteDto ToDto(List<Note> notes, Course course, Guid userId)
    {
        var notesForCourse = notes.Where(x => x.CourseHole.CourseId == course.Id).ToList();
        var holesWithNote = notesForCourse.Select(note => note.HoleId).Distinct().Count();
        var numberOfHoles = course.CourseHoles.Count;
        var numberOfHolesWithNotes = $"{holesWithNote} av {numberOfHoles}";

        var allHolesForCourse = _repository.GetAllHolesForCourse(course.Id);
        var notesForAllHoles = allHolesForCourse.Select(x => new CourseHoleNoteDto()
        {
            HoleName = $"Hull {x.HoleNumber}",
            HoleId = x.Id,
            LastUpdated = x.Notes
                .Select(n => n.LastUpdated)
                .DefaultIfEmpty() 
                .Max()
                .ToString("dd.MM.yyyy"),
            Notes = x.Notes?.Where((u => u.UserId == userId)).OrderBy(n => n.LastUpdated).Select(n => new NotesForHoleDto()
            {
                Content = n.NoteText,
                NoteId = n.Id,
            }).ToList(),
        }).ToList();

        var noteDto = new CourseNoteDto()
        {
            NumberOfHolesWithNotes = holesWithNote,
            NumberOfHoles = numberOfHoles,
            NumberOfHolesWithNotesText = numberOfHolesWithNotes,
            CourseName = course.CourseName,
            NotesForAllHoles = notesForAllHoles.OrderBy(x => x.HoleName).ToList(),
        };

        return noteDto;
    }

    public List<CourseRoundHoleStatsDto> ToDto(List<CourseRoundHoleStatsEntityDto> courseStatsEntity)
    {
        var numberFormat = new NumberFormatInfo { NumberDecimalSeparator = "." }; //Seperates by comma instead of dot
        var dto = courseStatsEntity.Select(x => new CourseRoundHoleStatsDto()
        {
            HoleNumber = x.HoleNumber.ToString("F1", numberFormat),
            HolePar = x.HolePar.ToString("F1", numberFormat),
            AverageScoreAsString = x.AverageScore.ToString("F1", numberFormat),
            Albatross = x.Albatross.ToString("F1", numberFormat),
            Eagle = x.Eagle.ToString("F1", numberFormat),
            Birde = x.Birde.ToString("F1", numberFormat),
            Par = x.Par.ToString("F1", numberFormat),
            Bogey = x.Bogey.ToString("F1", numberFormat),
            DoubleBogey = x.DoubleBogey.ToString("F1", numberFormat),
            TrippleBogey = x.TrippleBogey.ToString("F1", numberFormat)
        }).ToList();

        return dto;
    }
}