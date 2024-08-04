using Microsoft.AspNetCore.Mvc;
using Serenity_Sanctury_v1.Models;
using Serenity_Sanctury_v1.Models.DataLayer;

namespace Serenity_Sanctury_v1.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;

        private ApplicationDbContext context { get; set; }

        public AdminController(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Product());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var product = context.Products.Find(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                if (product.ProductID == 0)
                    context.Products.Add(product);
                else
                    context.Products.Update(product);
                context.SaveChanges();
                return RedirectToAction("ManageProducts", "Admin");
            }
            else
            {
                ViewBag.Action = (product.ProductID == 0) ? "Add" : "Edit";
                return View("~/Views/Admin/Edit.cshtml", product);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = context.Products.Find(id);
            return View("~/Views/Admin/Delete.cshtml", product);
        }

        [HttpPost]
        public IActionResult Delete(Product product)
        {
            context.Products.Remove(product);
            context.SaveChanges();
            return RedirectToAction("ManageProducts", "Admin");
        }

       
        public IActionResult ManageProducts()
        {
            //return View(context.Products.ToList());
            var products = context.Products.ToList();
            return View("~/Views/Admin/ManageProducts.cshtml", products);
        }

        public IActionResult Login()
        {
            return View("~/Views/Admin/ManageProducts.cshtml");
        }


    }
}
