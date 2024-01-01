using Lighthouse.Models;
using Microsoft.EntityFrameworkCore;

namespace Lighthouse.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {
        }

        public DbSet<Events> Events { get; set; }
        public DbSet<Announcements> Announcements { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Credentials> Credentials { get; set; }
        public DbSet<Club> Clubs { get; set; }


    }
    }