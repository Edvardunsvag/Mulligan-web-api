using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MulliganApi.Models
{
    public class Round
    {
        [Key]
        public int RoundId { get; set; }

        [ForeignKey("email")]
        public string Email { get; set; } = "";

        public List<Hole>? Holes { get; set; }

    }
}

