using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai1_Tinhtoan.Controllers
{
    public class TinhtoanController : Controller
    {
        // GET: Tinhtoan
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cong(int n1, int n2)
        {
            int x = n1 + n2;
            var result = n1 + " + " + n2 + " = " + x;
            var data = new { status = "OK", rs = result };
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Tru(int n1, int n2)
        {
            int x = n1 - n2;
            var result = n1 + " - " + n2 + " = " + x;
            var data = new { status = "OK", rs = result };
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Nhan(int n1, int n2)
        {
            int x = n1 * n2;
            var result = n1 + " x " + n2 + " = " + x;
            var data = new { status = "OK", rs = result };
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Chia(int n1, int n2)
        {
            float x = (float)(n1/n2);
            var result = n1 + " / " + n2 + " = " + x;
            var data = new { status = "OK", rs = result };
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}