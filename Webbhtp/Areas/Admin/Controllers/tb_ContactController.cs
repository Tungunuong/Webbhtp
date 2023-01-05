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
    public class tb_ContactController : Controller
    {
        private BanHangThucPhamEntities db = new BanHangThucPhamEntities();

        // GET: Admin/Contact
        public ActionResult Index()
        {
            return View(db.tb_Contact.ToList());
        }

        // GET: Admin/Contact/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Contact tb_Contact = db.tb_Contact.Find(id);
            if (tb_Contact == null)
            {
                return HttpNotFound();
            }
            return View(tb_Contact);
        }

        // GET: Admin/Contact/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Contact/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ContactId,Name,Phone,Email,Message,IsRead,CreatedDate")] tb_Contact tb_Contact)
        {
            if (ModelState.IsValid)
            {
                db.tb_Contact.Add(tb_Contact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_Contact);
        }

        // GET: Admin/Contact/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Contact tb_Contact = db.tb_Contact.Find(id);
            if (tb_Contact == null)
            {
                return HttpNotFound();
            }
            return View(tb_Contact);
        }

        // POST: Admin/Contact/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ContactId,Name,Phone,Email,Message,IsRead,CreatedDate")] tb_Contact tb_Contact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Contact).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_Contact);
        }

        // GET: Admin/Contact/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Contact tb_Contact = db.tb_Contact.Find(id);
            if (tb_Contact == null)
            {
                return HttpNotFound();
            }
            return View(tb_Contact);
        }

        // POST: Admin/Contact/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_Contact tb_Contact = db.tb_Contact.Find(id);
            db.tb_Contact.Remove(tb_Contact);
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
