using MulliganApi.Database.Enums;

namespace MulliganApi.Database.Models;

public class UserRole
{
    public Guid Id { get; set; }
    public User User { get; set; }
    public UserRoleEnum Role { get; set; }
}