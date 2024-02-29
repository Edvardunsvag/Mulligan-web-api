namespace MulliganApi.Dto;

public class ScoreBoardRound
{
    public Guid UserId { get; set; }
    public Guid RoundId { get; set; }
    public string Username { get; set; }
    public string Score { get; set; }
    public string Date { get; set; }
}