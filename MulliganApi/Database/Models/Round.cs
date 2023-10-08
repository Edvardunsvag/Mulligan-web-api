using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MulliganApi.Database.Models
{
    public class Round
    {
        public Guid RoundId { get; set; }
        public Guid UserId { get; set; }
        public Guid CourseId { get; set; }
        public int Strokes { get; set; }
        public int Puts { get; set; }


        //Helpers for EF core
        public List<RoundHole> Holes { get; set; }
    }
}

