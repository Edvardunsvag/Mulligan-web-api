﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MulliganApi.Dto
{
    public class UserRegisterRequestDto
    {
        [Required, EmailAddress]
        public string Email { get; set; } = "";

        [Required, MinLength(6)]
        public string Password { get; set; } = "";

        [Required, Compare("Password")]
        public string ConfirmPassword { get; set; } = "";


    }
}
