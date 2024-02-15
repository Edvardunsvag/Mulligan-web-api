namespace MulliganApi.Dto;

public class HoleGeneralStats
{
    public string ScoreName { get; set; }
    public double Percentage { get; set; } = 0.0;
    public string PercentageAsString { get; set; } = string.Empty;
    public int ScoreAmount { get; set; }
}