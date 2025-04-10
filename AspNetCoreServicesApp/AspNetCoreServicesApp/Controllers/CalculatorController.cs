using AspNetCoreServicesApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreServicesApp.Controllers
{
    public class CalculatorController : Controller
    {
        private ICalculatorService _calculatorService;

        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        public IActionResult Index()
        {
            int a = Convert.ToInt32(new Random().Next(1, 100));
            int b = Convert.ToInt32(new Random().Next(1, 100));
            int addResult = _calculatorService.Add(a, b);

            ViewBag.AddResult = addResult;
            return View();
        }
    }
}
