using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ShoppAppWebUI.Models;
using ShoppAppWebUI.ViewModels;

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

            var products = new List<Product>() {
                new Product() {Name = "Phone 1", Price = 1000, Desc = "Good Phone"},
                new Product() {Name = "Phone 2", Price = 2000, Desc = "Good Phone"},
            };

            var category = new Category() {Name = "Telefonlar", Desc = "Telefon Categorisi"};
            var productViewModel = new ProductViewModel() {Category = category, Products = products};

            return View(productViewModel);
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