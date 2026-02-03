using Microsoft.AspNetCore.Mvc;
using ModelPractice.Models;
using System.Diagnostics;

namespace ModelPractice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Student student = new Student()
            {
                Id = 1,
                Name = "John Doe",
                Age = 20,
                Gender = "Male",
                Course = "Advance Programming with .NET",
                Fee = 19000.50f,
             };
            //student.Id = 1;
            //student.Name = "John Doe";
            //student.Age = 20;
            //student.Gender = "Male";
            //student.Course = "Advance Programming with .NET";
            //student.Fee = 19000.50f;
            return View(student);
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
