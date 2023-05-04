using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab02.Models;

namespace Lab02.Controllers
{
    public class NhapDiemController : Controller
    {
        // GET: NhapDiem
        public ActionResult Index()
        {
            return View();
        }
        //public ActionResult XuLy() //Truyền tham số từ View sang Controller bằng Request
        //{
        //    //Requets["tham so"]
        //    string Ma = Request["id"];
        //    string Ten = Request["name"];
        //    double Diem = Convert.ToDouble(Request["marks"]);
        //    ViewBag.ma = Ma;
        //    ViewBag.ten = Ten;
        //    ViewBag.diem = Diem;

        //    return View();
        //}
        //public ActionResult XuLy(FormCollection data) //Truyền tham số từ View sang Controller bằng FormCollection
        //{
        //    //cần khai báo một đối tượng của FormColelction: data

        //    string Ma = data["Id"];
        //    string Ten = data["name"];
        //    double Diem = Convert.ToDouble(data["marks"]);
        //    ViewBag.ma = Ma;
        //    ViewBag.ten = Ten;
        //    ViewBag.diem = Diem;

        //    return View();
        //}

        ////Truyền tham số từ View sang Controller bằng Action argument
        //public ActionResult XuLy(string id=" ", string name="", double marks=0) 
        //{
        //    //đặt tên các tham số theo đúng các phân tử trên form

        //    ViewBag.ma = id;
        //    ViewBag.ten = name;
        //    ViewBag.diem = marks;

        //    return View();
        //}

        ////Truyền tham số từ View sang Controller bằng Models
        public ActionResult XuLy(SinhVien sv)
        {
            //đặt tên các tham số theo đúng các phân tử trên form

            ViewBag.ma = sv.Id;
            ViewBag.ten = sv.Name;
            ViewBag.diem = sv.Marks;

            return View();
        }
    }
}