using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using PagedList;
using Revision1.Models;

namespace Revision1.Controllers
{
    public class SanphamsController : Controller
    {
        private Model1 db = new Model1();

        // GET: Sanphams
        public ActionResult Index(string sortOrder, string searchingString)
        {
            //Các biến sắp xếp
            ViewBag.TheoTen = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.Gia = sortOrder == "Giatien" ? "gia_desc" : "Giatien";
            var sanphams = db.Sanphams.Include(s => s.Danhmuc);

            //Lọc theo tên hàng
            //if (!String.IsNullOrEmpty(searchingString))
            //{
            //    sanphams = sanphams.Where(s => s.Tenvd.Contains(searchingString));
            //}
            //else if (!String.IsNullOrEmpty(searchingString))
            //{
            //    var g = float.Parse(searchingString);
            //    sanphams = sanphams.Where(p => p.Giatien.Equals(g));
            //}
            if (!string.IsNullOrEmpty(searchingString))
            {
                var t = decimal.Parse(searchingString);
                sanphams = sanphams.Where(p => p.Giatien <= t);
            }

            //Sắp xếp
            switch (sortOrder)
            {
                case "name_desc":
                    sanphams = sanphams.OrderByDescending(s => s.Tenvd);
                    break;
                case "Giatien":
                    sanphams = sanphams.OrderBy(s => s.Giatien);
                    break;
                case "gia_desc":
                    sanphams = sanphams.OrderByDescending(s => s.Giatien);
                    break;
                default:
                    sanphams = sanphams.OrderBy(s => s.Tenvd); 
                    break;
            }
            return View(sanphams.ToList());
        }
        [Route("shop/danhmuc/{maDM?}")]
        public ActionResult SanphamByDanhmuc(int maDM)
        {
            ViewBag.tenDM = db.Danhmucs.Where(d => d.MaDanhmuc == maDM).SingleOrDefault().TenDanhmuc;
            return View(db.Sanphams.Where(p => p.MaDanhmuc == maDM).ToList());
        }

        public ActionResult DisplaySuplier(int? page)
        {
            var sanpham = db.Sanphams.Select(p => p);
            sanpham = sanpham.OrderBy(s => s.Mavd);
            int pageSize = 4;
            int pagenum = (page ?? 1);


            return View(sanpham.ToPagedList(pagenum, pageSize));
        }

        // GET: Sanphams/Details/5
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

        // GET: Sanphams/Create
        public ActionResult Create()
        {
            ViewBag.MaDanhmuc = new SelectList(db.Danhmucs, "MaDanhmuc", "TenDanhmuc");
            return View();
        }

        // POST: Sanphams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Mavd,Tenvd,Mota,TenAnh,Giatien,Soluong,MaDanhmuc")] Sanpham sanpham)
        {
            try
            {
                sanpham.TenAnh = "";
                var f = Request.Files["ImageFile"];
                if(f != null && f.ContentLength > 0)
                {
                    string FileName = System.IO.Path.GetFileName(f.FileName);
                    string UploadPath = Server.MapPath("~/Content/Images/" + FileName);
                    f.SaveAs(UploadPath);
                    sanpham.TenAnh = FileName;
                }
                db.Sanphams.Add(sanpham);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Lỗi nhập dữ liệu " + ex;
                ViewBag.MaDanhmuc = new SelectList(db.Danhmucs, "MaDanhmuc", "TenDanhmuc", sanpham.MaDanhmuc);
                return View(sanpham);
            }

        }

        // GET: Sanphams/Edit/5
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

        // POST: Sanphams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Mavd,Tenvd,Mota,TenAnh,Giatien,Soluong,MaDanhmuc")] Sanpham sanpham)
        {
            try
            {
                var f = Request.Files["ImageFile"];
                if (f != null && f.ContentLength > 0)
                {
                    string FileName = System.IO.Path.GetFileName(f.FileName);
                    string UploadPath = Server.MapPath("~/Content/Images/" + FileName);
                    f.SaveAs(UploadPath);
                    sanpham.TenAnh = FileName;
                }
                db.Entry(sanpham).State = EntityState.Modified;
                db.SaveChanges(); 
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            { 
                ViewBag.Error = "Lỗi nhập dữ liệu " + ex;
                ViewBag.MaDanhmuc = new SelectList(db.Danhmucs, "MaDanhmuc", "TenDanhmuc", sanpham.MaDanhmuc);
                return View(sanpham);
            };
        }

        // GET: Sanphams/Delete/5
        public ActionResult Delete(int? id)
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

        // POST: Sanphams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sanpham sanpham = db.Sanphams.Find(id);
            db.Sanphams.Remove(sanpham);
            db.SaveChanges();
            return RedirectToAction("Index");
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
