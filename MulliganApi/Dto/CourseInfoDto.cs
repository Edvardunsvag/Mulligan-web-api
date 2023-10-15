using MulliganApi.Database.Enums;

namespace MulliganApi.Dto
{
    public class CourseInfoDto
    {
        public Guid CourseId { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public string CourseDescription { get; set; } = string.Empty;
        public int Length { get; set; }
        public bool Has18Holes { get; set; }
        public List<int> TeeBoxes { get; set; } = new();
        public List<CourseHoleDto> Holes { get; set; }
    }
}
