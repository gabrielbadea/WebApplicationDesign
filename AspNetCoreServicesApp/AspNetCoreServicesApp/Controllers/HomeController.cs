using AspNetCoreServicesApp.Models;
using AspNetCoreServicesApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetCoreServicesApp.Controllers
{
    public class HomeController : Controller
    {
        //private ILog _log;

        public HomeController()
        {
            //_log = log;
        }

        public IActionResult Index([FromServices] ILog log, int? id)
        {
            log.Info("Executing /Home/Index");

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
