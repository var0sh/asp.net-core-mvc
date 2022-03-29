using System.Collections.Generic;
using ShoppAppWebUI.Models;

namespace ShoppAppWebUI.ViewModels
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }
        public Category Category { get; set; }
    }
}