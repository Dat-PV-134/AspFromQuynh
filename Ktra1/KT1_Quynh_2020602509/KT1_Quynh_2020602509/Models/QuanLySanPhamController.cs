using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KT1_Quynh_2020602509.Models;

namespace KT1_Quynh_2020602509.Models
{
    public class QuanLySanPhamController : Controller
    {
        // GET: QuanLySanPham

        List<SanPham> ds = new List<SanPham>();

        public QuanLySanPhamController()
        {
            ds.Add(new SanPham("S01", "Sản phẩm 1", 10, 100, 0));
            ds.Add(new SanPham("S02", "Sản phẩm 2", 20, 120, 1));
            ds.Add(new SanPham("S03", "Sản phẩm 3", 15, 200, 1));
            ds.Add(new SanPham("S04", "Sản phẩm 4", 30, 150, 0));
            ds.Add(new SanPham("S05", "Sản phẩm 5", 20, 50, 1));
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Hienthi2DS()
        {
            List<SanPham> ds1 = new List<SanPham>();
            List<SanPham> ds2 = new List<SanPham>();
            foreach(SanPham sp in ds)
            {
                if(sp.giatien > 100)
                {
                    ds1.Add(sp);
                }
                if(sp.giamgia == 1)
                {
                    ds2.Add(sp);
                }
            }
            ViewBag.ds1 = ds1;
            ViewBag.ds2 = ds2;

            return View(); 
        }
        public ActionResult Nhap()
        {
            return View();
        }
        public ActionResult HienThiNgay(SanPham sp)
        {
            ds.Add(sp);

            return View(sp);
        }
    }
}