using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ba411.Controllers
{
    public class TinhToanController : Controller
    {
        // GET: TinhToan
        public ActionResult TinhToan()
        {
            return View();
        }
        public ActionResult Tinh()
        {
            int a = int.Parse(Request.Form["so1"]);
            int b = int.Parse(Request.Form["so2"]);
            string pt = Request.Form["pt"];
            double result;

            if (pt == "cong")
            {
                result = a + b;
            }
            else if (pt == "tru")
            {
                result = a - b;
            }
            else if (pt == "nhan")
            {
                result = a * b;
            }
            else
            {
                result = (double)a / b;

            }
            ViewBag.msg = a + "\t" + pt + "\t" + b + " = " + result;

            return View("TinhToan");
        }
    }
}