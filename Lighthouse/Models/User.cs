using Lighthouse.Data;
using System.ComponentModel.DataAnnotations;

namespace Lighthouse.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Status { get; set; }

        public bool IsStudent { get; set; }
        public bool IsTeacher { get; set; }
        public string? SchoolEmail { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set; }

        // Navigation property for UserRole mappings
        public List<UserRole> UserRoles { get; set; }

    }
}