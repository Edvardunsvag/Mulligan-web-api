using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MulliganApi.Models
{
    public class Hole
    {
        [Key]
        public int HoleId { get; set; }

        public int Score { get; set; }

    }
}

