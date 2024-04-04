using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreServicesApp.Controllers
{
    public class TestController : Controller
    {
        //[Route("")]
        //[Route("Test")]
        //[Route("Test/Home")]
        public IActionResult Home()
        {
            return View();
        }

        //[Route("Test/About")]
        public IActionResult About()
        {
            return View();
        }

        //[Route("Test/Contact")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
