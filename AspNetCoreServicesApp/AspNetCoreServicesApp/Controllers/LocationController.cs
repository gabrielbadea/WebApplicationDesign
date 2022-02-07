using AspNetCoreServicesApp.Models;
using AspNetCoreServicesApp.Repositories.Interfaces;
using AspNetCoreServicesApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreServicesApp.Controllers
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

        [HttpPost]
        public IActionResult FindLocations(string locationType)
        {
            var locations = _locationService.GetLocationsByType(locationType);

            return Json(locations);
        }
    }
}
