namespace MulliganApi.Database.Models
{
    public class Note
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public CourseHole CourseHole { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string Content { get; set; }
    }
}
