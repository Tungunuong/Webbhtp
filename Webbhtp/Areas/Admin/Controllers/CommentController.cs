﻿using System;
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
    public class CommentController : Controller
    {
        private BanHangThucPhamEntities db = new BanHangThucPhamEntities();

        // GET: Admin/Comment
        public ActionResult Index()
        {
            var tb_Comment = db.tb_Comment.Include(t => t.tb_Blog);
            return View(tb_Comment.ToList());
        }

        // GET: Admin/Comment/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Comment tb_Comment = db.tb_Comment.Find(id);
            if (tb_Comment == null)
            {
                return HttpNotFound();
            }
            return View(tb_Comment);
        }

        // GET: Admin/Comment/Create
        public ActionResult Create()
        {
            ViewBag.BlogId = new SelectList(db.tb_Blog, "BlogId", "Image");
            return View();
        }

        // POST: Admin/Comment/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CmtId,BlogId,Name,Content,Date")] tb_Comment tb_Comment)
        {
            if (ModelState.IsValid)
            {
                db.tb_Comment.Add(tb_Comment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BlogId = new SelectList(db.tb_Blog, "BlogId", "Image", tb_Comment.BlogId);
            return View(tb_Comment);
        }

        // GET: Admin/Comment/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Comment tb_Comment = db.tb_Comment.Find(id);
            if (tb_Comment == null)
            {
                return HttpNotFound();
            }
            ViewBag.BlogId = new SelectList(db.tb_Blog, "BlogId", "Image", tb_Comment.BlogId);
            return View(tb_Comment);
        }

        // POST: Admin/Comment/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CmtId,BlogId,Name,Content,Date")] tb_Comment tb_Comment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Comment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BlogId = new SelectList(db.tb_Blog, "BlogId", "Image", tb_Comment.BlogId);
            return View(tb_Comment);
        }

        // GET: Admin/Comment/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Comment tb_Comment = db.tb_Comment.Find(id);
            if (tb_Comment == null)
            {
                return HttpNotFound();
            }
            return View(tb_Comment);
        }

        // POST: Admin/Comment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_Comment tb_Comment = db.tb_Comment.Find(id);
            db.tb_Comment.Remove(tb_Comment);
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
