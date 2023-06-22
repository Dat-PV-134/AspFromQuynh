using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Bai3.Models;

namespace Bai3.Controllers
{
    public class EmployeesController : Controller
    {
        private Model1 db = new Model1();

        [ChildActionOnly]

        public PartialViewResult CategoryMenu()
        {
            var list = db.Departments.ToList();
            return PartialView(list);
        }

        [Route("emps/empbydept/{deptid}")]
        public ActionResult ListEmployeeBuDeptid(int deptid)
        {
            var list = db.Employees.Where(e => e.deptid == deptid).ToList();
            return View(list);
        }

        // GET: Employees
        public ActionResult Index()
        {
            var employees = db.Employees.Include(e => e.Department);
            return View(employees.ToList());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            ViewBag.deptid = new SelectList(db.Departments, "deptid", "deptname");
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        
        public ActionResult Create(Employee emp)
        {
            try 
            {
                db.Employees.Add(emp);
                db.SaveChanges();
                return Json(new {result = true, JsonRequestBehavior.AllowGet});
            }
            catch(Exception er)
            {
                return Json(new {result = false, error = er.Message});
            }

        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            ViewBag.deptid = new SelectList(db.Departments, "deptid", "deptname", employee.deptid);
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            try
            {
                db.Entry(emp).State = EntityState.Modified;
                db.SaveChanges();
                return Json(new { result = true, JsonRequestBehavior.AllowGet });
            }
            catch(Exception er)
            {
                return Json(new { result = false, error = er.Message });
            }
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                var employee = db.Employees.Find(id);
                if (employee == null)
                {
                    return HttpNotFound();
                }

                db.Employees.Remove(employee);
                db.SaveChanges();

                return Json(new { result = true });
            }
            catch (Exception ex)
            {
                return Json(new { result = false, error = ex.Message });
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
