using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreServicesApp.Models;
using AspNetCoreServicesApp.Services.Interfaces;

namespace AspNetCoreServicesApp.Controllers;

public class HomeController : Controller
{
    private ILog _log;

    public HomeController(ILog log)
    {
        _log = log;
    }

    public IActionResult Index(int? id)
    {
        _log.Info("Executing /Home/Index");

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
