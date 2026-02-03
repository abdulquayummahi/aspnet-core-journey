using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewData.Models;

namespace ViewData.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["ProductId"] = 1;
            ViewData["ProductName"] = "Asus ROG RTX 5090 V2";
            ViewData["ProductPrice"] = 1999.99;
            ViewData["ProductQuantity"] = 2;
            return View();
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
