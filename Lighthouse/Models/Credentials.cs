using System.ComponentModel.DataAnnotations;

namespace Lighthouse.Models
{
    public class Credentials
    {
        [Key]
        public string UserName {  get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsStudent { get; set; }
        public bool IsTeacher { get; set; }
    }
}
