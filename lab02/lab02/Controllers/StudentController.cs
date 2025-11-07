using lab02.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace lab02.Controllers
{
    public class StudentController : Controller
    {
        private List<Student> listStudents = new List<Student>();

        public StudentController()
        {
            listStudents = new List<Student>()
            {
                new Student()
                {
                    Id=101,
                    Name="Le phong",
                    Email="phong@gmail.com",
                    Branch=Branch.IT,
                    Gender=Gender.Female,
                    IsRegular=true,
                    Address="Vinh phuc",
                    DateOfBorth=new DateTime(2005,6,2)
                },
                new Student()
                {
                    Id=102,
                    Name="Hai Nam",
                    Email="nam@gmail.com",
                    Branch=Branch.BE,
                    Gender=Gender.Male,
                    IsRegular=true,
                    Address="Vinh Phuc",
                    DateOfBorth=new DateTime(2005,1,5)
                },
                new Student()
                {
                    Id=103,
                    Name="Minh Tú",
                    Email="tu@gmail.com",
                    Branch=Branch.CE,
                    Gender=Gender.Female,
                    IsRegular=true,
                    Address="Ha Nam",
                    DateOfBorth=new DateTime(2005,1,6)
                },
                new Student()
                {
                    Id=104,
                    Name="Hoàng Phong",
                    Email="phong@gmail.com",
                    Branch=Branch.EE,
                    Gender=Gender.Male,
                    IsRegular=false,
                    Address="Hung Yen",
                    DateOfBorth=new DateTime(2005,1,7)
                },
            };

        }


        public IActionResult Index()
        {
            return View(listStudents);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            ViewBag.AllBranches = new List<SelectListItem>()
            {
                new SelectListItem {Text = "IT", Value = "1"},
                new SelectListItem {Text = "BE", Value = "2"},
                new SelectListItem {Text = "CE", Value = "3"},
                new SelectListItem {Text = "EE", Value = "4"}
            };
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student s)
        {
            s.Id = listStudents.Last<Student>().Id + 1;
            listStudents.Add(s);
            return View("Index", listStudents);
        }
    }
}
