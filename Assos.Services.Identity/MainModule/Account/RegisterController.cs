using Microsoft.AspNetCore.Mvc;

namespace Assos.Services.Identity.MainModule.Account
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
