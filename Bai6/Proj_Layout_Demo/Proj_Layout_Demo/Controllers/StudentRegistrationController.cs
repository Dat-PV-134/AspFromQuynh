using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proj_Layout_Demo.Models;

namespace Proj_Layout_Demo.Controllers
{
    public class StudentRegistrationController : Controller
    {
        // GET: StudentRegistration
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Regis(Student s)
        {
            return View(s);
        }
        public ActionResult Regis2(FormCollection f)
        {
            Student s = new Student();
            s.name = f["name"];
            s.gender = f["gender"];
            s.email = f["email"];
            s.addr  = f["addr"];

            // checkbox
            string strtemp = "";
            if (f["History"] == "true, false")
            {
                strtemp += "History";
            }
            if (f["Science"] == "true, false")
            {
                strtemp += "  Science"; 
            }
            if (f["Geography"] == "true, false")
            {
                strtemp += "  Geography"; 
            }
            s.subject = strtemp;
            s.username = f["username"];
            s.password = f["password"];
            s.comment = f["comment"];
            
            return View("Regis", s);
        }
    }
}