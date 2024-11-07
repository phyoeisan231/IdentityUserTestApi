﻿using System.ComponentModel.DataAnnotations;
namespace IdentityUserTestApi.DTOs
{
    public class ResetPasswordDto
    {
        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string? ConfirmPassword { get; set; }
        public string? Email { get; set; }
    }
}
