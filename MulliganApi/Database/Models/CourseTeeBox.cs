using MulliganApi.Database.Enums;

namespace MulliganApi.Database.Models
{
    public class CourseTeeBox
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public TeeBoxEnum TeeBox { get; set; }
    }
}
