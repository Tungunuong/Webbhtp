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
    public class UserController : Controller
    {
        private BanHangThucPhamEntities db = new BanHangThucPhamEntities();

        // GET: Admin/User
        public ActionResult Index()
        {
            return View(db.tb_User.ToList());
        }

        // GET: Admin/User/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_User tb_User = db.tb_User.Find(id);
            if (tb_User == null)
            {
                return HttpNotFound();
            }
            return View(tb_User);
        }

        // GET: Admin/User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/User/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserID,FirstName,LastName,Email,Password,IsAdmin")] tb_User tb_User)
        {
            if (ModelState.IsValid)
            {
                db.tb_User.Add(tb_User);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_User);
        }

        // GET: Admin/User/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_User tb_User = db.tb_User.Find(id);
            if (tb_User == null)
            {
                return HttpNotFound();
            }
            return View(tb_User);
        }

        // POST: Admin/User/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserID,FirstName,LastName,Email,Password,IsAdmin")] tb_User tb_User)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_User).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_User);
        }

        // GET: Admin/User/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_User tb_User = db.tb_User.Find(id);
            if (tb_User == null)
            {
                return HttpNotFound();
            }
            return View(tb_User);
        }

        // POST: Admin/User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_User tb_User = db.tb_User.Find(id);
            db.tb_User.Remove(tb_User);
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
