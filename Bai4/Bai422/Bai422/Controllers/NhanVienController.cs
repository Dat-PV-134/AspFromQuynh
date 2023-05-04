using Bai422.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai422.Models;

namespace Bai422.Controllers
{
    public class NhanVienController : Controller
    {
        // GET: NhanVien
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TinhLuong(NhanVien nv)
        {
            int chucvu = nv.ChucVu;
            double phucap;
            if (chucvu == 0)
            {
                phucap = 500000;

            }
            else if (chucvu == 1)
            {
                phucap = 300000;
            }
            else
                phucap = 0;

            int ngayluong;
            if (nv.Ngaycong < 25)
                ngayluong = nv.Ngaycong;
            else
                ngayluong = ((nv.Ngaycong - 25) * 2) + 25;
            ViewBag.tienlinh = nv.Bac * 650000 * ngayluong + phucap;
            ViewBag.ma = nv.Id;
            ViewBag.ngaycong = nv.Ngaycong;

            return View(nv);
        }
    }
}