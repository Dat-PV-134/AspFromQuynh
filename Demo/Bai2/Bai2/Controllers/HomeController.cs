using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EditEmployee(int id)
        {
            return Content("<h1>id = "+id + "</h1>");
        }

        public ActionResult EditEmployeeVer2(int empid)
        {
            return Content("<h1>id = " + empid +"</h1>");
        }
        public ActionResult Demparametters(int? pageIndex, String sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            return Content("pageIndex: " + pageIndex + " sortBy" + sortBy);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}