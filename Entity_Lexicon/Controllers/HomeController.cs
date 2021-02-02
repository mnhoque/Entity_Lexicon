using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Entity_Lexicon.Models;

namespace Entity_Lexicon.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext db;

        public HomeController(ApplicationDbContext context)
        {
            db = context;
        }

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult InsertStudents()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InsertStudents(string sname)
        {
            if (sname != null )
            {
                var student = new Student();
                //course.Id = C_Id;
                student.Student_Name = sname;
                //student.Course_Id = c_id;
                db.Students.Add(student);
                //db.Courses.Add(course);
                db.SaveChanges();
            }
            return View();
        }

        public IActionResult InsertTeacher()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InsertTeacher(string tname, int tid)//,int cid
        {
            if (tname != null )
            {
                var teacher = new Teacher();
                //course.Id = C_Id;
                teacher.Teacher_Name = tname;
                teacher.TeacherId = tid;
                db.Teachers.Add(teacher);
                db.SaveChanges();
            }
            else
            {
                ViewBag.name = "There is a error message";
            }
            return View();
        }

        public IActionResult InsertCourse()
        {
            return View();
        }
        [HttpPost]
        public IActionResult InsertCourse(string cname, string cdescription,int t_id)
        {
            if (cname != null || cdescription!=null||t_id != 0)
            {
                var course = new Course();
                //course.Id = C_Id;
                course.CourseName = cname;
                course.description = cdescription;
                course.Teacher_Id = t_id;
                db.Courses.Add(course);
                db.SaveChanges();
            }
            else
            {
                ViewBag.name = "There is a error message";
            }
            return View("Index"); 
        }

        public IActionResult Insert_Student_Course()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insert_Student_Course(int sId, int c_Id)
        {
            if (sId != 0 || c_Id != 0)
            {
                var student_Course = new StudentCourse();
                //course.Id = C_Id;
                student_Course.StudentId = sId;
                student_Course.CourseId = c_Id;
                db.StudentCourses.Add(student_Course);
                
                //db.Courses.Add(course);
                db.SaveChanges();
            }
            else
            {
                ViewBag.name = "There is a error message";
            }
            return View("Index");
        }

        public IActionResult DetailsforCourse()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DetailsforCourse (int c_Id)
        {
            List<Info_Based_Course> selectedlist = new List<Info_Based_Course>();
            if (c_Id != 0)
            {
                var courseId = db.Courses.Where(x => x.Id == c_Id);

                
                //listOfPeople.Where(x => x.EmpName == id).FirstOrDefault();
                var assign = new Assignment();
                //course.Id = C_Id;
                assign.Course_Id = c_Id;
                db.Assignments.Add(assign);

                db.SaveChanges();
            }
            else
            {
                ViewBag.name = "There is a error message";
            }
            return View("Index");
        }

        public IActionResult Insert_Assignments()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insert_Assignments(int c_Id)
        {
            if (c_Id != 0)
            {
                var assign= new Assignment();
                //course.Id = C_Id;
                assign.Course_Id = c_Id;
                db.Assignments.Add(assign);
               
                db.SaveChanges();
            }
            else
            {
                ViewBag.name = "There is a error message";
            }
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
