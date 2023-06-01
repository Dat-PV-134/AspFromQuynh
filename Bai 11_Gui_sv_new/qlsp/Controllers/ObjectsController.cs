using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using qlsp.Models;

namespace qlsp.Controllers
{
    public class ObjectsController : Controller
    {
        private Model1 db = new Model1();

        // GET: Objects
        //public ActionResult Index()
        //{
        //    var sanphams = db.Sanphams.Include(s => s.Danhmuc);
        //    return View(sanphams.ToList());
        //}
        public ActionResult Xemdanhsach(string searchingString)
        {

            var sanphams = db.Sanphams.Include(s => s.Danhmuc);
            if (!string.IsNullOrEmpty(searchingString))
            {
                var g = float.Parse(searchingString);
                sanphams = sanphams.Where(p => p.Giatien.Equals(g));
            }           

            return View(sanphams.ToList());
        }
        
        // GET: Objects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sanpham sanpham = db.Sanphams.Find(id);
            if (sanpham == null)
            {
                return HttpNotFound();
            }
            return View(sanpham);
        }

        // GET: Objects/Create
        public ActionResult ThemDuLieu()
        {
            ViewBag.MaDanhmuc = new SelectList(db.Danhmucs, "MaDanhmuc", "TenDanhmuc");
            return View();
        }

        //POST: Objects/Create
        //To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ThemDuLieu([Bind(Include = "Mavd,Tenvd,TenAnh,Mota,Giatien,Soluong,MaDanhmuc")] Sanpham sanpham)
        {
            try
            {
                sanpham.TenAnh = "";
                var f = Request.Files["ImageFile"];
                if(f != null && f.ContentLength > 0)
                {
                    string FileName = System.IO.Path.GetFileName(f.FileName);
                    string UpLoadFile = Server.MapPath("~/Content/Images/" + FileName);
                    f.SaveAs(UpLoadFile);
                    sanpham.TenAnh = FileName;
                }
                db.Sanphams.Add(sanpham);
                db.SaveChanges();
                return RedirectToAction("Xemdanhsach");
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Lỗi khi tạo mới " + ex.Message;
                ViewBag.MaDanhmuc = new SelectList(db.Danhmucs, "MaDanhmuc", "TenDanhmuc", sanpham.MaDanhmuc);
                return View(sanpham);
            }

        }

        // GET: Objects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sanpham sanpham = db.Sanphams.Find(id);
            if (sanpham == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaDanhmuc = new SelectList(db.Danhmucs, "MaDanhmuc", "TenDanhmuc", sanpham.MaDanhmuc);
            return View(sanpham);
        }

        // POST: Objects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Mavd,Tenvd,TenAnh,Mota,Giatien,Soluong,MaDanhmuc")] Sanpham sanpham)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sanpham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaDanhmuc = new SelectList(db.Danhmucs, "MaDanhmuc", "TenDanhmuc", sanpham.MaDanhmuc);
            return View(sanpham);
        }

        // GET: Objects/Delete/5
        public ActionResult XoaDuLieu(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sanpham sanpham = db.Sanphams.Find(id);
            if (sanpham == null)
            {
                return HttpNotFound();
            }
            return View(sanpham);
        }

        // POST: Objects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sanpham sanpham = db.Sanphams.Find(id);
            try
            {
                db.Sanphams.Remove(sanpham);
                db.SaveChanges();
                return RedirectToAction("Xemdanhsach");
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Không xóa được sản phẩm này" + ex.Message;
                return View("XoaDuLieu", sanpham);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
