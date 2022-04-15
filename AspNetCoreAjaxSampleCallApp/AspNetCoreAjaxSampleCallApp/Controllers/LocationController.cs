using AspNetCoreAjaxSampleCallApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreAjaxSampleCallApp.Controllers
{
    public class LocationController : Controller
    {
        private readonly List<Location> _locations = new List<Location>()
        {
            new Location { IsNumber = true, LocationName = "Location 1" },
            new Location { IsNumber = true, LocationName = "Location 2" },
            new Location { IsNumber = true, LocationName = "Location 3" },
            new Location { IsNumber = false, LocationName = "Location x" },
            new Location { IsNumber = false, LocationName = "Location y" }
        };

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FindLocations(string locationType)
        {
            var locations = new List<Location>();

            if (locationType == "numeric_locations")
            {
                locations = _locations.Where(l => l.IsNumber == true).ToList();
            }
            else if (locationType == "textual_locations")
            {
                locations = _locations.Where(l => l.IsNumber == false).ToList();
            }

            return Json(locations);
        }
    }
}
