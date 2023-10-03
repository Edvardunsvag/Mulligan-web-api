using System.ComponentModel.DataAnnotations.Schema;

namespace MulliganApi.Database.Models
{
    public class CourseHole
    {
       public Guid Id { get; set; }

        [ForeignKey("CourseId")]
        public Guid CourseId { get; set; }
        public int Par { get; set; }
        public int HoleNumber { get; set; }
        public int Length { get; set; }
        public List<Note> Notes { get; set; }

    }
}
