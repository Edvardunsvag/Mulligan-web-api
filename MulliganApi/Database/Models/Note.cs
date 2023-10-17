using System.ComponentModel.DataAnnotations.Schema;

namespace MulliganApi.Database.Models
{
    public class Note
    {
        public Guid Id { get; set; }
        public string NoteText { get; set; }
        public DateTime LastUpdated { get; set; }
        public Guid UserId { get; set; }
        public Guid HoleId { get; set; }
        
        
        
        [ForeignKey("HoleId")]
        public CourseHole CourseHole { get; set; }
    }
}
