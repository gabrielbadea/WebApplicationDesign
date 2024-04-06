using AspNetCoreServicesRepositoryApp.Models;
using AspNetCoreServicesRepositoryApp.Repositories.Interfaces;

namespace AspNetCoreServicesRepositoryApp.Repositories
{
    public class LocationRepository : RepositoryBase<Location>, ILocationRepository
    {
        public LocationRepository(LocationContext locationContext)
            : base(locationContext)
        {
        }
    }
}
