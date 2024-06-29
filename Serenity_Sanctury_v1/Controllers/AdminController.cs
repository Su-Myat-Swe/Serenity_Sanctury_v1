using Microsoft.AspNetCore.Mvc;

namespace Serenity_Sanctury_v1.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
