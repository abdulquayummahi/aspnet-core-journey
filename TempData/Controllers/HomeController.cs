using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TempData.Models;

namespace TempData.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            TempData["Message"] = "This message is from Index";
            return RedirectToAction("HomePage");
        }

        public IActionResult HomePage()
        {
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
