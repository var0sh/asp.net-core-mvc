using Microsoft.AspNetCore.Mvc;
using ShoppAppWebUI.Models;

namespace ShoppAppWebUI.Controllers
{
    public class ProductController: Controller
    {
        // localhost:5000/product/index
        public IActionResult Index() {
            return View();
        }

        // localhost:5000/product/list
        public IActionResult List() {
            return View();
        }

        // localhost:5000/product/details
        public IActionResult Details(int id) {
            
            // ViewBag.PrdName = "Phone 1";
            // ViewBag.PrdPrice = 3000;
            // ViewBag.PrdDesc = "Good mobile phone";
            
            var p = new Product() {
                Name = "Phone 1",
                Price = 2000,
                Desc = "Good mobile phone"
            };

            return View(p);
        }
    }
}