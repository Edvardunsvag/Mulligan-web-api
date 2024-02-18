namespace MulliganApi.Dto;

public class CourseRoundHoleStatsDto
{
    public string HoleNumber { get; set; }
    public string HolePar { get; set; }
    public string AverageScoreAsString { get; set; } = string.Empty;
    public string Albatross { get; set; }
    public string Eagle { get; set; }
    public string Birde { get; set; }
    public string Par { get; set; }
    public string Bogey { get; set; }
    public string DoubleBogey { get; set; }
    public string TrippleBogey { get; set; }
}