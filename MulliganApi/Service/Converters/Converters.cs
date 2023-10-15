using MulliganApi.Database.Models;
using MulliganApi.Database.Repository;
using MulliganApi.Dto;

namespace MulliganApi.Service.Converters;

public interface IConverters
{
    RoundGetDto ToDto(Round round);
    CourseInfoDto ToDto(Course course, List<CourseTeeBox> teeBoxes);
    Task<CourseNoteDto> ToDtoAsync(List<Note> notes, Course course, Guid userId);
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
            Length = course.Length,
            Holes = course.CourseHoles.Select(x => new CourseHoleDto()
            {
                HoleNumber = x.HoleNumber,
                Par = x.Par,
                HoleId = x.Id
            }).OrderBy(x => x.HoleNumber).ToList(),
        };

        return courseInfo;
    }
    
    public async Task<CourseNoteDto> ToDtoAsync(List<Note> notes, Course course, Guid userId)
    {
        var notesForCourse = notes.Where(x => x.CourseHole.CourseId == course.Id);
        var holeNotesWithEmptyContentCount = notesForCourse.Count(holeNote => holeNote.NoteText != "");
        var numberOfHolesWithNotes = $"{holeNotesWithEmptyContentCount} av 9";

        var allHolesForCourse = await _repository.GetAllHolesForCourse(course.Id);
        var notesForAllHoles = allHolesForCourse.Select(x => new CourseHoleNoteDto()
        {
            HoleName = $"Hull {x.HoleNumber}",
            Notes = x.Notes?.Where((u => u.UserId == userId)).Select(n => n.NoteText). ToList(),
        }).ToList();

        var noteDto = new CourseNoteDto()
        {
            NumberOfHolesWithNotes = numberOfHolesWithNotes,
            CourseName = course.CourseName,
            NotesForAllHoles = notesForAllHoles.OrderBy(x => x.HoleName).ToList(),
        };

        return noteDto;
    }
}