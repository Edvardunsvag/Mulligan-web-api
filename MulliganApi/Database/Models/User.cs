using System;
using System.ComponentModel.DataAnnotations;
using MulliganApi.Database.Enums;

namespace MulliganApi.Database.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string? Email { get; set; }
        public List<UserRole> Roles { get; set; } = new();
        public byte[] PasswordHash { get; set; } = new byte[64];
        public byte[] PasswordSalt { get; set; } = new byte[64];
        public string? VerificationToken { get; set; }
        public List<UserRatings>? UserRatings { get; set; }
    }
}