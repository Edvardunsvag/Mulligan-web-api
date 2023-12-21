namespace MulliganApi.Dto;

public class CourseGeneralStats
{
    public int TotalNumberOfHolesPlayed { get; set; }
    public int AverageStrokes { get; set; }
    public string AverageStrokesAsString { get; set; }
    public double AverageScore { get; set; }
    public string AverageScoreAsString  { get; set; }
    public int Albatross { get; set; }
    public int Eagle { get; set; }
    public int Birde { get; set; }
    public int Par { get; set; }
    public int Bogey { get; set; }
    public int DoubleBogey { get; set; }
    public int TrippleBogey { get; set; }

}