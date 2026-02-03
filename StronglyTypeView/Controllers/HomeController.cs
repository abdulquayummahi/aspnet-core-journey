using Microsoft.AspNetCore.Mvc;
using StronglyTypeView.Models;
using System.Diagnostics;

namespace StronglyTypeView.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var product = new Product()
            {
                ProductId = 1,
                ProductName = "Laptop",
                ProductPrice = 1200.50f,
                ProductQuantity = 5,
            };
            return View(product);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
