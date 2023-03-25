using Microsoft.EntityFrameworkCore;

namespace AspNetCoreServicesApp.Models
{
    public class LocationContext : DbContext
    {
        public LocationContext(DbContextOptions<LocationContext> options)
            : base(options)
        { }

        public DbSet<Location>? Locations { get; set; }
    }
}
