using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreServicesApp.Controllers
{
    public class TestController : Controller
    {
        [Route("")]
        [Route("Test")]
        [Route("Test/Home")]
        //[AcceptVerbs("GET")]
        public IActionResult Home()
        {
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("Test/Contact")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
