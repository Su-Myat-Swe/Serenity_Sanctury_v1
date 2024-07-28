using Microsoft.AspNetCore.Mvc;

namespace Serenity_Sanctury_v1.ViewModels
{
    public class LoginVM : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
