namespace MulliganApi.Dto
{
    public class RoundGetDto
    {
        public Guid CourseId { get; set; }
        public int Strokes { get; set; }
        public int Puts { get; set; }
        public List<RoundHoleDto> Holes { get; set; }

    }
}
