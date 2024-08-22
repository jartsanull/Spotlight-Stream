using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Spotlight_Stream.Models;

namespace Spotlight_Stream.Data
{
    // Inherit from IdentityDbContext to include ASP.NET Core Identity tables and functionality
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Define DbSet properties for your custom entities
        public DbSet<Message> Messages { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
