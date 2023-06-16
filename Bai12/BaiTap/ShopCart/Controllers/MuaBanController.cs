using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopCart.Models;

namespace ShopCart.Controllers
{
    public class MuaBanController : Controller
    {
        // GET: MuaBan
        public ActionResult Index()
        {
            List<SanPham> ds = new List<SanPham>();
            ds.Add(new SanPham("sp01", "IPhone 12 128","iphone-12.jpg", 2000));
            ds.Add(new SanPham("sp02", "Samsung Galaxy 21", "samsung-galaxy-s21.jpg", 1500));
            ds.Add(new SanPham("sp03", "Oppo Find N2 Flip", "Oppo-Find-N2-Flip.jpg", 1400));
            ds.Add(new SanPham("sp04", "Vivo Y518", "Vivo-Y518.jpg", 600));

            Session["hanghoa"] = ds;
            return View(ds);
        }
        public ActionResult ChonMua(SanPhamMua spm)
        {
            List<SanPhamMua> dsmua = (List<SanPhamMua>)Session["giohang"];
            if(dsmua == null)
            {
                dsmua = new List<SanPhamMua>();

            }
            if(dsmua.Contains(spm)) { 
                int vitri = dsmua.IndexOf(spm);
                dsmua[vitri].soluong++;
            }
            else
            {
                spm.soluong = 1;
                dsmua.Add(spm);
            }
            Session["giohang"] = dsmua;
            return View();
        }
        public ActionResult XoaSanPham(string masp)
        {
            List<SanPhamMua> dsmua = (List<SanPhamMua>)Session["giohang"];
            SanPhamMua s = new SanPhamMua();
            s.masp = masp;
            int vitri = dsmua.IndexOf(s);
            s = dsmua[vitri];
            dsmua.Remove(s);
            Session["giohang"] = dsmua;
            return View("ChonMua");
        }
        public ActionResult XemGioHang()
        {
            List<SanPhamMua> dsmua = (List<SanPhamMua>)Session["giohang"];
            
            return View(dsmua);
        }
        public ActionResult DatMua()
        {
            List<SanPhamMua> dsmua = (List<SanPhamMua>)Session["giohang"];
            Session.Remove("giohang");
            return View(dsmua);
        }
    }
}