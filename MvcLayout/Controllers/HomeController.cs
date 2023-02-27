using Microsoft.AspNetCore.Mvc;
using MvcLayout.Models;

namespace MvcLayout.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Greeting"] = "Hello world";
            ViewData["Product"] = new ProductModel()
            // ViewBag.Product = new ProductModel()

             {
                Id = 1,
                Name = "TEDU",
                Brand = "TEDU",
                Price = 1000

            };
            return View();
        }
    }
}
