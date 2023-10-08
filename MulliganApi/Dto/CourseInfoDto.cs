using MulliganApi.Database.Enums;

namespace MulliganApi.Dto
{
    public class CourseInfoDto
    {
        public string CourseName { get; set; } = string.Empty;
        public string CourseDescription { get; set; } = string.Empty;
        public List<int> TeeBoxes { get; set; } = new();
        public int Length { get; set; }
        public bool Has18Holes { get; set; }
    }
}
