namespace MulliganApi.Dto;

public class UserDto
{
    public Guid UserId { get; set; }
    public string Name { get; set; }
    public string? VerificationToken { get; set; }
}