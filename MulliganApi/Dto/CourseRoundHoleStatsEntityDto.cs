namespace MulliganApi.Dto;

public record CourseRoundHoleStatsEntityDto
{
    public int HoleNumber { get; set; }
    public int HolePar { get; set; }
    public double AverageScore { get; set; } = 0.0;
    public string AverageScoreAsString { get; set; } = string.Empty;
    public int Albatross { get; set; }
    public int Eagle { get; set; }
    public int Birde { get; set; }
    public int Par { get; set; }
    public int Bogey { get; set; }
    public int DoubleBogey { get; set; }
    public int TrippleBogey { get; set; }
}