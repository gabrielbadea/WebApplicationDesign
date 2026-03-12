using AspNetCoreServicesRepositoryApp.Models;

namespace AspNetCoreServicesRepositoryApp.Services.Interfaces
{
    public interface ILocationService
    {
        List<Location> GetLocationsByType(string locationType);
    }
}
