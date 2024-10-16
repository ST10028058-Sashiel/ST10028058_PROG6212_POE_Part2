using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ST10028058_PROG6212_POE_Part2.Models;

namespace ST10028058_PROG6212_POE_Part2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }

        // Add this line to include the Claims DbSet
        public DbSet<Claim> Claims { get; set; }
    }
}
