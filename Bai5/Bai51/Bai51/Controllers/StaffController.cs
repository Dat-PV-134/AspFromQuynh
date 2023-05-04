using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai51.Models;

namespace Bai51.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Save(FormCollection f)
        {
            var fhinh = Request.Files["myfileImage"];
            var pathhinh = Server.MapPath("~/Image/" + fhinh.FileName);
            fhinh.SaveAs(pathhinh);

            string path = Server.MapPath("~/Staffinfo.txt");
            string[] info = { f["txtID"], f["txtName"], f["txtDate"], f["txtSalary"], fhinh.FileName };

            System.IO.File.WriteAllLines(path, info);

            return View("Index");
        }

        public ActionResult Open()
        {
            string path = Server.MapPath("~/Staffinfo.txt");
            string[] info = System.IO.File.ReadAllLines(path);

            Staff s = new Staff();
            s.StaffId = int.Parse(info[0]);
            s.StaffName = info[1];
            s.BirthOfDate = DateTime.Parse(info[2]);
            s.Salary = decimal.Parse(info[3]);
            s.StaffImage = info[4];

            ViewBag.id = s.StaffId;
            ViewBag.name = s.StaffName;
            ViewBag.birthday = s.BirthOfDate.ToString("yyyy-MM-dd");
            ViewBag.salary = s.Salary;
            ViewBag.image = "../../Image/" + s.StaffImage;

            return View("Index");
        }
    }
}
