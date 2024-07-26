using Microsoft.AspNetCore.Mvc;

namespace Serenity_Sanctury_v1.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
 

    }
}
