using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai412.Models;

namespace Bai412.Controllers
{
    public class DienController : Controller
    {
        // GET: Dien
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult XuLy(NguoiTieuDung td)
        {

            int soDien = td.soMoi - td.soCu;
            double tien;

            if (soDien <= 100)
            {
                tien = soDien * 2000;
            }
            else if (soDien <= 150)
            {
                tien = 100 * 2000 + (soDien - 100) * 2500;
            }
            else if (soDien <= 200)
            {
                tien = 100 * 2000 + 50 * 2500 + (soDien - 150) * 3000;
            }
            else
            {
                tien = 100 * 2000 + 50 * 2500 + 50 * 3000 + (soDien - 200) * 4000;
            }

            if (td.loaiTT == loaiTD.KinhDoanh)
            {
                tien = tien * 1.2;
            }
            else if (td.loaiTT == loaiTD.SanXuat)
            {
                tien = tien * 1.3;
            }

            if (td.hoUuTien)
            {
                tien = tien * 0.9;
            }

            ViewBag.ten = td.name;
            ViewBag.soDien = soDien;
            ViewBag.tien = tien;
            return View(td);
        }
    }
}