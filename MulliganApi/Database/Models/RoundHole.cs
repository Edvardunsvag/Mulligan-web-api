﻿namespace MulliganApi.Database.Models
{
    public class RoundHole
    {
        public Guid Id { get; set; }
        public Guid RoundId { get; set; }
        public int HoleNumber { get; set; }
        public int Par { get; set; }
        public int Score { get; set; }
        public int Puts { get; set; }
    }
}
