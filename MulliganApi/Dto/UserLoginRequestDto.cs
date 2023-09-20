using System;
using System.ComponentModel.DataAnnotations;

namespace MulliganApi.Dto
{
    public class UserLoginRequestDto
    {
        [Required, EmailAddress]
        public string Email { get; set; } = "";

        [Required]
        public string Password { get; set; } = "";

    }
}

