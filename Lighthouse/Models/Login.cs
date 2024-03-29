﻿using System.ComponentModel.DataAnnotations;
namespace Lighthouse.Models;
public class Login
{
    [Required(ErrorMessage = "Username is required.")]
    public string? Username { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }
}


