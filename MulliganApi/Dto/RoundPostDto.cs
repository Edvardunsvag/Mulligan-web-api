using MulliganApi.Database.Models;

namespace MulliganApi.Dto
{
    public class RoundPostDto
    {
        public Guid UserId { get; set; }
        public Guid CourseId { get; set; }
        public int Strokes { get; set; }
        public List<RoundHoleDto> RoundHoles { get; set; }

        public List<NoteDto> holeNotes { get; set; }

    }
}
