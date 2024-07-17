using Microsoft.AspNetCore.Mvc;

namespace Serenity_Sanctury_v1.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
