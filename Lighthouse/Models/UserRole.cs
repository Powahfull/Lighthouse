namespace Lighthouse.Models
{
    public class UserRole
    {
        public int UserRoleId { get; set; }

        // Foreign key for User
        public int UserId { get; set; }
        public User User { get; set; }

        // Role (e.g., "User", "Admin", "ClubAdmin")
        public string Role { get; set; }
    }
}
