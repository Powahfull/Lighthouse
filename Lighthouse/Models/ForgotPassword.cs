﻿using System.ComponentModel.DataAnnotations;
namespace Lighthouse.Models;

public class ForgotPassword
{
    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email address.")]
    public string? Email { get; set; }
}


