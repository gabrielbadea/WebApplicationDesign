using AspNetCoreServicesRepositoryApp.Models;
using AspNetCoreServicesRepositoryApp.Repositories.Interfaces;
using AspNetCoreServicesRepositoryApp.Services.Interfaces;

namespace AspNetCoreServicesRepositoryApp.Services
{
    public class LocationService : ILocationService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public LocationService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public List<Location> GetLocationsByType(string locationType)
        {
            var locations = new List<Location>();

            if (locationType == "numeric_locations")
            {
                locations = _repositoryWrapper.LocationRepository.FindByCondition(l => l.IsNumber == true).ToList();
            }
            else if (locationType == "textual_locations")
            {
                locations = _repositoryWrapper.LocationRepository.FindByCondition(l => l.IsNumber == false).ToList();
            }

            return locations;
        }
    }
}
