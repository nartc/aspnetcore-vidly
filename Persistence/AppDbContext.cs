using aspnetcore_vidly.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnetcore_vidly.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Make> Makes { get; set; }
    }
}