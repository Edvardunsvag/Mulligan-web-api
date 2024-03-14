namespace MulliganApi.Dto;

public class ScoreBoardCourseCard
{
    public Guid CourseId { get; set; }
    public string Placement { get; set; }
    public string CourseName { get; set; }
    public string NumberOfRoundsPlayed { get; set; }
}