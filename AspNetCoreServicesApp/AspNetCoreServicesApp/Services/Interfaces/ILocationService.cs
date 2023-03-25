using AspNetCoreServicesApp.Models;

namespace AspNetCoreServicesApp.Services.Interfaces
{
    public interface ILocationService
    {
        List<Location> GetLocationsByType(string locationType);
    }
}
