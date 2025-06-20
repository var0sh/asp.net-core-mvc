using System;
using Microsoft.AspNetCore.Mvc;

namespace ShoppAppWebUI.Controllers
{
    // localhost:5000/home
    public class HomeController: Controller
    {
        // localhost:5000/home/index
        public IActionResult Index() {
            int hour = DateTime.Now.Hour;
            
            ViewBag.Greeting = hour > 12 ? "İyi Günler" : "Günaydın"; 
            ViewBag.UserName = "Taha";

            return View();
        }

        // localhost:5000/home/about
        public IActionResult About() {
            return View();
        }
        
        // localhost:5000/home/about
        public IActionResult Contact() {
            return View("MyView");
        }
    }
}