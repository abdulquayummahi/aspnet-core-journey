using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewBag.Models;

namespace ViewBag.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.RegistrationNo = 101;
            ViewBag.Name = "John Doe";
            ViewBag.Course = "ASP.NET";
            ViewBag.Fee = 15500.99;
            ViewBag.Vat = 0.50;
            //ViewData["RegistrationNo"] = 101;
            //ViewData["Name"] = "John Doe";
            //ViewData["Course"] = "ASP.NET";
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
