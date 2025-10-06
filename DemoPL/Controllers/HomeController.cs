using System.Diagnostics;
using DemoPL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DemoPL.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) // dependency injection
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation($"Now i am in the index"); 
            return View();
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation($"Now i am in the privacy");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
