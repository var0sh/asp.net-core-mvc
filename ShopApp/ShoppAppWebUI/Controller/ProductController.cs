using Microsoft.AspNetCore.Mvc;

namespace ShoppAppWebUI.Controllers
{
    public class ProductController: Controller
    {
        // localhost:5000/product/index
        public string Index() {
            return "product/index";
        }

        // localhost:5000/product/list
        public string List() {
            return "product/list";
        }

        // localhost:5000/product/details
        public string Details(int id) {
            return "product/details/" + id;
        }
    }
}