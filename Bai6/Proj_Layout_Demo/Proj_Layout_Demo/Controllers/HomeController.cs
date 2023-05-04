using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proj_Layout_Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My layout";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "https://sv.dhcnhn.vn/";

            return View();
        }
    }
}