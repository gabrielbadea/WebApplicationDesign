using AspNetCoreServicesRepositoryApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreServicesRepositoryApp.Controllers
{
    public class LocationController : Controller
    {
        private ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FindLocations(string locationType)
        {
            var locations = _locationService.GetLocationsByType(locationType);

            return Json(locations);
        }
    }
}
