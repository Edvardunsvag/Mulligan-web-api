using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MulliganApi.Database.Enums;

namespace MulliganApi.Database.Models;

public class UserRatings
{
    public Guid Id { get; set; }
    public User User { get; set; }
    public DateTime RatingDate { get; set; }
    public RatingEnum Rating { get; set; }
}