using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Diagnostics;


namespace MVC.Controllers
{
    
    public class Data
    {
        public static List<Student> model = new List<Student>()
        {
            new Student{Id = 40011, Name = "Narotsit Karki", Section = 'A'},

            new Student{Id = 40012, Name = "Subrat Regmi", Section = 'A'},

            new Student{Id = 40013, Name = "Ankit Rai", Section = 'A'},

            new Student{Id = 40014, Name = "Suman Khatiwada", Section = 'B'},

            new Student{Id = 40015, Name = "Madhu Ghimire", Section = 'B'},
        };

    }
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Students()
        {

            var model = Data.model.OrderBy(stu => stu.Id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Create_Student(Student student)
        {
            Data.model.Add(student);
            return RedirectToAction("Students");
        }

        [HttpPost]
        public IActionResult Edit_student(Student stu)
        {
            Student student = Data.model.Single(stud => stud.Id == stu.Id);
            student.Name = stu.Name;
            student.Section = stu.Section;

            return RedirectToAction("Students");
        }

        public IActionResult Delete(int Id)
        {
            Student delete_student = Data.model.Single(stu => stu.Id == Id);
            Data.model.Remove(delete_student);
            return RedirectToAction("Students");
        }
        public IActionResult Edit(int Id)
        {
            Student model = Data.model.Single(stu => stu.Id == Id);
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Details(int Id)
        {


            Student model = Data.model.Single(stu => stu.Id == Id);
            return View(model);
        }

        public IActionResult Index()
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