using System.ComponentModel.DataAnnotations;
namespace Lighthouse.Models;
public class SignUp
{
    [Required(ErrorMessage = "Name is required.")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Surname is required.")]
    public string? Surname { get; set; }

    [Required(ErrorMessage = "Please specify whether you are registering as a student or teacher.")]
    public bool IsStudent { get; set; }
    public bool IsTeacher { get; set; }

    [Required(ErrorMessage = "School email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email address.")]
    public string? SchoolEmail { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }

    [Compare("Password", ErrorMessage = "Passwords do not match.")]
    [DataType(DataType.Password)]
    public string? ConfirmPassword { get; set; }
}



