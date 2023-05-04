using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab01.Models;

namespace Lab01.Controllers
{
    public class NhapDiemController : Controller
    {
        // GET: NhapDiem
        public ActionResult Index()
        {
            return View();
        }

        //Controller sang View bằng ViewBag/ViewData
        public ActionResult Detail()
        {
            ViewBag.Id = "SV001";
            ViewBag.name = "Nguyễn ANh Tuaans";
            ViewData["mark"] = 9.5;
            return View();
        }

        //Controller sang View bằng Model
        public ActionResult Details(SinhVien sv)
        {
            sv.Id = "SV001";
            sv.Name = "Nguyễn Anh Tuấn";
            sv.Marks = 9.5;

            //truyền đối tượng sv cho View
            return View(sv);
        }
    }
}