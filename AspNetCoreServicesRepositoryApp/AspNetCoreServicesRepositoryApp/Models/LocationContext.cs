using Microsoft.EntityFrameworkCore;

namespace AspNetCoreServicesRepositoryApp.Models
{
    public class LocationContext : DbContext
    {
        public LocationContext(DbContextOptions<LocationContext> options)
            : base(options)
        { }

        public DbSet<Location>? Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seeding of data
            modelBuilder.Entity<Location>().HasData(
                new Location { LocationId = 1, IsNumber = true, LocationName = "Location 1" },
                new Location { LocationId = 2, IsNumber = true, LocationName = "Location 2" },
                new Location { LocationId = 3, IsNumber = false, LocationName = "Location A" },
                new Location { LocationId = 4, IsNumber = false, LocationName = "Location B" }
            );
        }
    }
}
