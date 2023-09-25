using MulliganApi.Database.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace MulliganApi.Database.Models
{
    public class Course
    {
        public Guid Id { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public string CourseDescription { get; set; } = string.Empty;


        //Helpers for EF core
        public List<CourseHole> CourseHoles { get; set; } = new();
    }
}
