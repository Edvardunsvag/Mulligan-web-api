namespace MulliganApi.Dto;

public class CourseHoleDto
{
    public Guid HoleId { get; set; }
    public int HoleNumber { get; set; }
    public int Par { get; set; }
    public int Score { get; set; }
    public int Puts { get; set; }
    public int Length { get; set; }
}