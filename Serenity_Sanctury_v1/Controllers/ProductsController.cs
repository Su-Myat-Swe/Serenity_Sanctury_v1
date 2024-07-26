using Microsoft.AspNetCore.Mvc;
using Serenity_Sanctury_v1.Data;
using Serenity_Sanctury_v1.Models;

namespace Serenity_Sanctury_v1.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext context { get; set; }


        public ProductsController(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            List<Product> products = context.Products.ToList();
            return View(products);
        }


        public IActionResult ProductDetails(int id) 
        {
            Product product = context.Products.FirstOrDefault(c => c.ProductID == id);
            return View(product);
        }
    }
}
