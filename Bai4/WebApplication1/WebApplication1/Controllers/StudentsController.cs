using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult ViewAStudent()
        {
            Student s = new Student(1, "Van Anh", "Hanoi", 9);
            return View(s);
        }

        public ActionResult ViewAllStudent()
        {
            List<Student> li = new List<Student>();
            li.Add(new Student(1, "Van Anh", "Hanoi", 9));
            li.Add(new Student(2, "Lan Anh", "Hanam", 7));
            li.Add(new Student(3, "Hoang Anh", "ThaiBinh", 8));
            li.Add(new Student(4, "Minh Anh", "NinhBinh", 8));
            return View(li);
        }

        public ActionResult ViewCourseStudent()
        {
            Course c = new Course(1, "Java");

            List<Student> li = new List<Student>();
            li.Add(new Student(1, "Van Anh", "Hanoi", 9));
            li.Add(new Student(2, "Lan Anh", "Hanam", 7));
            li.Add(new Student(3, "Hoang Anh", "ThaiBinh", 8));
            li.Add(new Student(4, "Minh Anh", "NinhBinh", 8));

            CourseStudent cs = new CourseStudent();
            cs.course = c;
            cs.students = li;

            return View(cs);
        }
        public ActionResult View3List()
        {

            List<Student> li1 = new List<Student>();
            li1.Add(new Student(1, "Van Anh", "Hanoi", 9));
            li1.Add(new Student(2, "Lan Anh", "Hanoi", 7));
            li1.Add(new Student(3, "Hoang Anh", "Hanoi", 8));
            li1.Add(new Student(4, "Minh Anh", "Hanoi", 8));

            List<Student> li2 = new List<Student>();
            li2.Add(new Student(5, "Van Anh", "Hanam", 9));
            li2.Add(new Student(6, "Lan Anh", "Hanam", 7));
            li2.Add(new Student(7, "Hoang Anh", "Hanam", 8));
            li2.Add(new Student(8, "Minh Anh", "Hanam", 8));

            List<Student> li3 = new List<Student>();
            li3.Add(new Student(9, "Van Anh", "ThaiBinh", 9));
            li3.Add(new Student(10, "Lan Anh", "ThaiBinh", 7));
            li3.Add(new Student(11, "Hoang Anh", "ThaiBinh", 8));

            ViewBag.hnoi = li1;
            ViewBag.hn = li2;
            ViewBag.tb = li3;

            return View();
        }
    }
}