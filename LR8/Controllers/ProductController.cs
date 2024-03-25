using LR8.Models;
using Microsoft.AspNetCore.Mvc;

namespace LR8.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
           
            var products = new List<Product>
            {
                new Product { ID = 1, Name = "Some product #1", Price = 1, CreatedDate = DateTime.Now.AddDays(-1) },
                new Product { ID = 2, Name = "Some product #2", Price = 20, CreatedDate = DateTime.Now.AddDays(-7) },
                new Product { ID = 3, Name = "Some product #3", Price = 100, CreatedDate = DateTime.Now.AddDays(-30) }
            };

            return View(products);
        }
    }
}
