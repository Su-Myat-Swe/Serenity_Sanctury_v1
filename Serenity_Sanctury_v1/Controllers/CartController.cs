using Microsoft.AspNetCore.Mvc;

namespace Serenity_Sanctury_v1.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
