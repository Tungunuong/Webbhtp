using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Webbhtp;

namespace Webbhtp.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        private BanHangThucPhamEntities db = new BanHangThucPhamEntities();

        // GET: Admin/Order
        public ActionResult Index()
        {
            var tb_Order = db.tb_Order.Include(t => t.tb_User);
            return View(tb_Order.ToList());
        }

        // GET: Admin/Order/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Order tb_Order = db.tb_Order.Find(id);
            if (tb_Order == null)
            {
                return HttpNotFound();
            }
            return View(tb_Order);
        }

        // GET: Admin/Order/Create
        public ActionResult Create()
        {
            ViewBag.UserId = new SelectList(db.tb_User, "UserID", "FirstName");
            return View();
        }

        // POST: Admin/Order/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrderId,UserId,Code,CustomerName,Phone,Email,Address,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy")] tb_Order tb_Order)
        {
            if (ModelState.IsValid)
            {
                db.tb_Order.Add(tb_Order);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(db.tb_User, "UserID", "FirstName", tb_Order.UserId);
            return View(tb_Order);
        }

        // GET: Admin/Order/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Order tb_Order = db.tb_Order.Find(id);
            if (tb_Order == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserId = new SelectList(db.tb_User, "UserID", "FirstName", tb_Order.UserId);
            return View(tb_Order);
        }

        // POST: Admin/Order/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrderId,UserId,Code,CustomerName,Phone,Email,Address,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy")] tb_Order tb_Order)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Order).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(db.tb_User, "UserID", "FirstName", tb_Order.UserId);
            return View(tb_Order);
        }

        // GET: Admin/Order/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Order tb_Order = db.tb_Order.Find(id);
            if (tb_Order == null)
            {
                return HttpNotFound();
            }
            return View(tb_Order);
        }

        // POST: Admin/Order/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_Order tb_Order = db.tb_Order.Find(id);
            db.tb_Order.Remove(tb_Order);
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
