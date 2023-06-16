using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proj_Ajax.Controllers
{
    public class AjaxDemo1Controller : Controller
    {
        // GET: AjaxDemo1
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Math(int n1, int n2)
        {
            var x = n1+ n2;
            var result = n1 + " + " + n2 + " = " + x;
            var data = new {status = "OK", rs = result};
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}