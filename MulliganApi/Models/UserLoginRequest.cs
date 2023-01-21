﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MulliganApi.Models
{
    public class UserLoginRequest
    {
        [Required, EmailAddress]
        public string Email { get; set; } = "";

        [Required]
        public string Password { get; set; } = "";

    }
}

