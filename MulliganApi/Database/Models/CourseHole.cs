﻿namespace MulliganApi.Database.Models
{
    public class CourseHole
    {
       public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public int Par { get; set; }
        public int HoleNumber { get; set; }
        public int Length { get; set; }
    }
}
