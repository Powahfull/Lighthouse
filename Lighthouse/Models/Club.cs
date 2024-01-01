using Lighthouse.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lighthouse.Models
{
    public class Club
    {
        public int ClubId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] ProfilePicture { get; set; }

        // Navigation property for ClubAdministrators
        [Required]
        public string ClubAdmins { get; set; }
    }
}
