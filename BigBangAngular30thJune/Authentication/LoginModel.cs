﻿using System.ComponentModel.DataAnnotations;

namespace BigBangAngular30thJune.Authentication
{
    public class LoginModel
    {
        [Required]
        public string Username { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
