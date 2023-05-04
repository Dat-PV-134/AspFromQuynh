using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Display()
        {
            //return PartialView("_EmployeeDetail");
            //return new EmptyResult();

            //chuyển hướng tới 1 url
            //return Redirect("https://vnexpress.net/");

            //chuyển hướng tới 1 method khác
            //return RedirectToAction("Welcome", "Haui");

            //action method trả về 1 xâu Json
            //return Json("Hello", JsonRequestBehavior.AllowGet);
            
            //action method trả về 1 luồng dữ liệu không yêu cầu view()
            //return Content("Hello Everyone");

            //action method trả về file cho Client
            //return new FilePathResult(@"E:\AspNet_in_Haui\Demo\Bài 3.pdf", "application/pdf");
            //return new FilePathResult(@"E:\AspNet_in_Haui\Demo\Song.txt", "text/lain");
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