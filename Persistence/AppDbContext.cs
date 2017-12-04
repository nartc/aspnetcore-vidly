using aspnetcore_vidly.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnetcore_vidly.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<VehicleFeature>().HasKey(vf => 
                new {vf.VehicleId, vf.FeatureId});
        }
    }
}