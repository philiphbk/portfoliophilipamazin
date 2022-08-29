using IdentityManager.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityManager.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
                
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Projects> Projects { get; set; } 
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Experience> Experience { get; set; }




    }
}
