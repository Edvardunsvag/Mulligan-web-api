namespace MulliganApi.Dto;

public class CourseHoleNoteDto
{
    public string HoleName { get; set; }
    public String? LastUpdated { get; set; }
    public List<NotesForHoleDto>? Notes { get; set; }
}