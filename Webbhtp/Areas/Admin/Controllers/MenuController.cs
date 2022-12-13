using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Webbhtp.Areas.Admin.Controllers
{
    public class MenuController : Controller
    {
        // GET: Admin/Menu
        private BanHangThucPhamEntities db = new BanHangThucPhamEntities();

        // GET: Admin/tb_Menu
        public ActionResult Index(string searchText)
        {
            var items = db.tb_Menu.ToList();
            if (!string.IsNullOrEmpty(searchText))
            {
                items = items.Where(i => i.Title.ToLower().Contains(searchText.ToLower())).ToList();
            }
            return View(items);
        }

        // GET: Admin/tb_Menu/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Menu tb_Menu = db.tb_Menu.Find(id);
            if (tb_Menu == null)
            {
                return HttpNotFound();
            }
            return View(tb_Menu);
        }

        // GET: Admin/tb_Menu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/tb_Menu/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MenuId,Title,Alias,Description,Position,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,IsActive")] tb_Menu tb_Menu)
        {
            if (ModelState.IsValid)
            {
                db.tb_Menu.Add(tb_Menu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_Menu);
        }

        // GET: Admin/tb_Menu/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Menu tb_Menu = db.tb_Menu.Find(id);
            if (tb_Menu == null)
            {
                return HttpNotFound();
            }
            return View(tb_Menu);
        }

        // POST: Admin/tb_Menu/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MenuId,Title,Alias,Description,Position,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,IsActive")] tb_Menu tb_Menu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Menu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_Menu);
        }

        // GET: Admin/tb_Menu/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Menu tb_Menu = db.tb_Menu.Find(id);
            if (tb_Menu == null)
            {
                return HttpNotFound();
            }
            return View(tb_Menu);
        }

        // POST: Admin/tb_Menu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                tb_Menu tb_Menu = db.tb_Menu.Find(id);
                db.tb_Menu.Remove(tb_Menu);
                db.SaveChanges();
                return Json(new { status = true });
            }
            catch
            {
                return Json(new { status = false });
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
