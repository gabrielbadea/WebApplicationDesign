using AspNetCoreServicesApp.Models;
using AspNetCoreServicesApp.Repositories.Interfaces;

namespace AspNetCoreServicesApp.Repositories
{
    public class LocationRepository : RepositoryBase<Location>, ILocationRepository
    {
        public LocationRepository(LocationContext locationContext)
            : base(locationContext)
        {
        }
    }
}
