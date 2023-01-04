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
    public class BlogController : Controller
    {
        private BanHangThucPhamEntities db = new BanHangThucPhamEntities();

        // GET: Admin/Blog
        public ActionResult Index()
        {
            return View(db.tb_Blog.ToList());
        }

        // GET: Admin/Blog/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Blog tb_Blog = db.tb_Blog.Find(id);
            if (tb_Blog == null)
            {
                return HttpNotFound();
            }
            return View(tb_Blog);
        }

        // GET: Admin/Blog/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Blog/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BlogId,Image,CreatedDate,CreatedBy,Description,Detail,IsActive,content")] tb_Blog tb_Blog)
        {
            if (ModelState.IsValid)
            {
                db.tb_Blog.Add(tb_Blog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_Blog);
        }

        // GET: Admin/Blog/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Blog tb_Blog = db.tb_Blog.Find(id);
            if (tb_Blog == null)
            {
                return HttpNotFound();
            }
            return View(tb_Blog);
        }

        // POST: Admin/Blog/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BlogId,Image,CreatedDate,CreatedBy,Description,Detail,IsActive,content")] tb_Blog tb_Blog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Blog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_Blog);
        }

        // GET: Admin/Blog/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Blog tb_Blog = db.tb_Blog.Find(id);
            if (tb_Blog == null)
            {
                return HttpNotFound();
            }
            return View(tb_Blog);
        }

        // POST: Admin/Blog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_Blog tb_Blog = db.tb_Blog.Find(id);
            db.tb_Blog.Remove(tb_Blog);
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
