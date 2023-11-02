namespace MulliganApi.Dto;

public class CourseGeneralStats
{
    public double AverageStrokes { get; set; }
    public int TotalNumberOfHolesPlayed { get; set; }
    public int Eagle { get; set; }
    public int Birde { get; set; }
    public int Par { get; set; }
    public int Bogey { get; set; }
    public int DoubleBogey { get; set; }
}