using Microsoft.AspNetCore.Mvc;

namespace DemoPL.Controllers
{
    public class TestController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public TestController(ILogger<HomeController> logger) // dependency injection
        {
            _logger = logger;
        }
        public IActionResult Text()
        {
            _logger.LogInformation($"now i am in the TEST");
            return View();
        }
    }
}
