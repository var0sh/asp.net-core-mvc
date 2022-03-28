using Microsoft.AspNetCore.Mvc;
using ShoppAppWebUI.Models;

namespace ShoppAppWebUI.Controllers
{
    public class ProductController: Controller
    {
        // localhost:5000/product/index
        public IActionResult Index() {
            // *** View'e veri aktarma yöntemleri => ViewBag, ViewData, Model

            // ViewData
            var product = new Product() {Name = "Phone 2", Price = 5000, Desc = "Good Phone"};

            // ViewData["Product"] = product;
            // ViewData["Category"] = "Telefon";


            // ViewBag
            // ViewBag.Category = "Telefonlar";
            // ViewBag.Product = product;

            return View(product/*Model ile View'e veri aktarma*/);
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