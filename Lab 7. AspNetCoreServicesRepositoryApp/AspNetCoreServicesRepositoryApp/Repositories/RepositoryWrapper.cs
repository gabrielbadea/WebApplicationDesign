using AspNetCoreServicesRepositoryApp.Models;
using AspNetCoreServicesRepositoryApp.Repositories.Interfaces;

namespace AspNetCoreServicesRepositoryApp.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private LocationContext _locationContext;
        private ILocationRepository? _locationRepository;

        public ILocationRepository LocationRepository
        {
            get
            {
                if (_locationRepository == null)
                {
                    _locationRepository = new LocationRepository(_locationContext);
                }

                return _locationRepository;
            }
        }

        public RepositoryWrapper(LocationContext locationContext)
        {
            _locationContext = locationContext;
        }

        public void Save()
        {
            _locationContext.SaveChanges();
        }
    }
}
