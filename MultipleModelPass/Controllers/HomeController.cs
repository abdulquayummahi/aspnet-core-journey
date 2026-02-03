using Microsoft.AspNetCore.Mvc;
using MultipleModelPass.Models;
using System.Diagnostics;

namespace MultipleModelPass.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowStudents()
        {
            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    Name = "Alice",
                    Course = "Mathematics",
                    Gender = "Male",
                },
                new Student()
                {
                    Id = 2,
                    Name = "Bob",
                    Course = "Physics",
                    Gender = "Male",
                },
                new Student()
                {
                    Id = 3,
                    Name = "Cathy",
                    Course = "Chemistry",
                    Gender = "Female",
                },
                new Student()
                {
                    Id = 4,
                    Name = "David",
                    Course = "Biology",
                    Gender = "Male",
                }
            };
            return View(students);
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
