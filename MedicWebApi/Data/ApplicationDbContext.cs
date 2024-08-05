using Microsoft.EntityFrameworkCore;
using System;

namespace MedicWebApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }

    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public DateTime LastLoginDate { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ImageURL { get; set; } = string.Empty;
        public int Orders { get; set; }
    }

}
