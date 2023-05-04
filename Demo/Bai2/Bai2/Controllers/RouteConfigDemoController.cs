using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai2.Controllers
{
    public class RouteConfigDemoController : Controller
    {
        // GET: RouteConfigDemo/Testparameters/Hello/7
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Testparameters(string msg, int number)
        {
            string str = "";
            for (int i = 0; i < number; i++)
            {
                str += i + " . " + msg + "<br/>";
            }
            return Content(str);
        }

        //định tuyến ngay trên phương thức
        [Route("haui/testpara2/{msg=Hello World}/{number = 5}")]
        public ActionResult TestparametersV2(string msg, int number)
        {
            string str = "";
            for (int i = 0; i < number; i++)
            {
                str += i + " . " + msg + "<br/>";
            }
            return Content(str);
        }
    }
}