using Microsoft.EntityFrameworkCore;
using PortofolioStarLabs.Models;

namespace PortofolioStarLabs.Persistence
{
    public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {
            }
            public DbSet<Project> Projects { get; set; }
            public DbSet<Photo> Photos { get; set; }
            public DbSet<Contact> Contacts { get; set; }
    }
    
}
