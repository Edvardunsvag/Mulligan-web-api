using static MulliganApi.Service.MulliganService;

namespace MulliganApi.Dto
{
    public class CourseNoteDto
    {
        public string CourseName { get; set; }
        public string NumberOfHolesWithNotesText { get; set; }
        public int NumberOfHolesWithNotes { get; set; }
        public int NumberOfHoles { get; set; }
        public List<CourseHoleNoteDto> NotesForAllHoles { get; set; }
    }
}
