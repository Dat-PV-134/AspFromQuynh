using Bai421.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai421.Models;

namespace Bai421.Controllers
{
    public class NhapDiemController : Controller
    {
        // GET: NhapDiem
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult XuLy(ThiSinh ts)
        {
            float diem = ts.toan + ts.ly + ts.hoa;
            if (ts.chinh)
            {
                diem += 1;
            }
            if(ts.khuvuc == khuvuc.KhuVuaA)
            {
                diem += 1;
            }
            else if(ts.khuvuc == khuvuc.KhuVuaB)
            {
                diem += 2;
            }
            else
            {
                diem += 3;
            }

            string kq;
            if(diem >= 20)
            {
                kq = "Đỗ Đại học";
            }
            else if(diem >= 15) 
            {
                kq = "Đỗ Cao đẳng";
            
            }
            else if(diem >= 10)
            {
                kq = "Đỗ Trung câp";
            }
            else 
            {
                kq = "Trượt!";
            }

            ViewBag.ten = ts.name;
            ViewBag.diem = diem;
            ViewBag.kq=kq;

            return View(ts);
        }
    }
}