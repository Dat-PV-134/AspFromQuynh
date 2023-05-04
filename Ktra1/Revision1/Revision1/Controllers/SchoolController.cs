using Revision1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Revision1.Models;

namespace Revision1.Controllers
{
    public class SchoolController : Controller
    {
        // GET: School
        public ActionResult Welcome()
        {
            return View();
        }

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Test()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DisplayAStudent(Students s)
        {
            return View(s);
        }

        public ActionResult DisplayListStudent()
        {
            List<Students> li = new List<Students>();
            li.Add(new Students("s01", "Lan", 19, "hn"));
            li.Add(new Students("s02", "Hoang", 20, "hp"));
            li.Add(new Students("s03", "Van Anh", 18, "hp"));
            li.Add(new Students("s04", "Tuan", 19, "hn"));

            

            return View(li);
        }

        public ActionResult DisplayCourseStudent()
        {
            CourseStudent cs = new CourseStudent();
            cs.course.cId = "C01";
            cs.course.cName = "Java";

            List<Students> li = new List<Students>();
            li.Add(new Students("s01", "Lan", 19, "hn"));
            li.Add(new Students("s02", "Hoang", 20, "hp"));
            li.Add(new Students("s03", "Van Anh", 18, "hp"));
            li.Add(new Students("s04", "Tuan", 19, "hn"));

            cs.students = li;

            return View(cs);
        }

        public ActionResult DisplayListTwoStudent()
        {
            List<Students> li1 = new List<Students>();
            li1.Add(new Students("s01", "Lan", 19, "hn"));
            li1.Add(new Students("s02", "Hoang", 20, "hp"));
            li1.Add(new Students("s03", "Van Anh", 18, "hp"));
            li1.Add(new Students("s04", "Tuan", 19, "hn"));

            List<Students> li2 = new List<Students>();
            li2.Add(new Students("s08", "Mai Phuong", 19, "hn"));
            li2.Add(new Students("s09", "Long", 20, "hp"));
            li2.Add(new Students("s10", "Van Anh", 18, "hp"));
            li2.Add(new Students("s11", "Tuan", 19, "hn"));

            //ViewData, TempData

            ViewBag.li1 = li1;
            ViewBag.li2 = li2;

            return View();
        }

        public ActionResult TinhToan()
        {

            return View();
        }
        public ActionResult Tinh()
        {
            int a = int.Parse(Request.Form["num1"]);
            int b = int.Parse(Request.Form["num2"]);
            string pt = Request.Form["pheptinh"];
            double result;

            if(pt == "+")
            {
                result = a + b;
            }
            else if(pt == "-")
            {
                result = a - b;
            }
            else if(pt == "*")
            {
                result = a * b;
            }
            else
            {
                result = (double)a/b ;
            }

            ViewBag.msg = a + "\t" + pt + "\t" + b + " = " + result;

            return View("TinhToan");
        }

    }
}