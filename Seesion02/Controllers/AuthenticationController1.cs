using Microsoft.AspNetCore.Mvc;

namespace Seesion02.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }
        public IActionResult Registration()
        {
            return View();
        }
    }
}
