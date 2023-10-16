using System;
using System.ComponentModel.DataAnnotations;

namespace MulliganApi.Dto
{
    public class UserLoginRequestDto
    {
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";

    }
}

