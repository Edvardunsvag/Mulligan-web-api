using System.Globalization;
using MulliganApi.Database.Models;
using MulliganApi.Database.Repository;
using MulliganApi.Dto;

namespace MulliganApi.Service.Converters;

public interface IConverters
{
    RoundGetDto ToDto(Round round);
    CourseInfoDto ToDto(Course course, List<CourseTeeBox> teeBoxes);
    CourseNoteDto ToDtoAsync(List<Note> notes, Course course, Guid userId);
}

public class Converters : IConverters
{
    private readonly MulliganRepository _repository;

    public Converters(MulliganRepository repository)
    {
        _repository = repository;
    }
    public  RoundGetDto ToDto(Round round)
    {
        var courses =  _repository.GetAllCourses();
        var connectedCourse = courses.First(x => x.Id == round.CourseId);
        var norwegianDate = FormatNorwegianDate(round.Date);
        
        var roundDto = new RoundGetDto()
        {
            CourseId = round.CourseId,
            Strokes = round.Strokes,
            Puts = round.Puts,
            NorwegianDate = norwegianDate,
            CourseName = connectedCourse.CourseName,
            Holes = round.Holes.Select(x => new RoundHoleDto()
            {
                HoleNumber = x.HoleNumber,
                Score = x.Score,
                Puts = x.Puts,
            }).ToList()
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
    
    public  CourseNoteDto ToDtoAsync(List<Note> notes, Course course, Guid userId)
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

    private static string FormatNorwegianDate(DateTime date)
    {
        var month = date.Month;
        var day = date.Day;
        var monthName = CultureInfo.GetCultureInfo("no").DateTimeFormat.GetMonthName(month);
        monthName = char.ToUpper(monthName[0]) + monthName.Substring(1);
        var formattedDate = $"{day}. {monthName}";

        return formattedDate;
    }
}