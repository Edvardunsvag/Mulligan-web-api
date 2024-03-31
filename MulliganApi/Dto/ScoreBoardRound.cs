namespace MulliganApi.Dto;

public class ScoreBoardRound
{
    public Guid UserId { get; set; }
    public Guid RoundId { get; set; }
    public Guid CourseId { get; set; }
    public string Username { get; set; }
    public string CourseName { get; set; }
    public string Score { get; set; }
    public string Date { get; set; }
    public int Strokes { get; set; }
}