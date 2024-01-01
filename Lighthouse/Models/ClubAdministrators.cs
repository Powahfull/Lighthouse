namespace Lighthouse.Models
{
    public class ClubAdministrators : User
    {

        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int ClubId { get; set; }
        public Club Club { get; set; }

        // Foreign key for User
        public int UserId { get; set; }
        public User User { get; set; }

        public ClubAdministrators() {
            var clubAdmin = new ClubAdministrators();

        }
    }
}
