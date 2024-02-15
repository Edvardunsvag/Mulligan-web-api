using MulliganApi.Database.Enums;
using MulliganApi.Database.Models;

namespace MulliganApi.Dto;

public class UserRatingsDto
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public DateTime RatingDate { get; set; }
    public RatingEnum Rating { get; set; }
}