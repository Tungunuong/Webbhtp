using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Webbhtp.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        // GET: Admin/Product
        // GET: Admin/Menu
        private BanHangThucPhamEntities db = new BanHangThucPhamEntities();

        // GET: Admin/tb_Product
        public ActionResult Index(string searchText)
        {
            var items = db.tb_Product.ToList();
            if (!string.IsNullOrEmpty(searchText))
            {
                items = items.Where(i => i.Title.ToLower().Contains(searchText.ToLower())).ToList();
            }
            return View(items);
        }

        // GET: Admin/tb_Product/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Product tb_Product = db.tb_Product.Find(id);
            if (tb_Product == null)
            {
                return HttpNotFound();
            }
            return View(tb_Product);
        }

        // GET: Admin/tb_Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/tb_Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductID,Title,Alias,Price,PriceSale,Quantity,IsNew,IsBestSeller,IsActive,CategoryProductId")] tb_Product tb_Product, HttpPostedFileBase image)
        {
                if (image != null && image.ContentLength > 0)
                {
                    string _fn = Path.GetFileName(image.FileName);
                    string path = Path.Combine(Server.MapPath("/Content/images/"), _fn);
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                        image.SaveAs(path);
                    }
                    else
                    {
                        image.SaveAs(path);
                    }
                    tb_Product.Image = "/Content/images/" + _fn;
                }

            if (ModelState.IsValid)
            {
                db.tb_Product.Add(tb_Product);
                db.SaveChanges();
              
                return RedirectToAction("Index");
            }
            return View(tb_Product);
        }

        // GET: Admin/tb_Product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Product tb_Product = db.tb_Product.Find(id);
            if (tb_Product == null)
            {
                return HttpNotFound();
            }
            return View(tb_Product);
        }

        // POST: Admin/tb_Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductID,Title,Alias,Image,Price,PriceSale,Quantity,IsNew,IsBestSeller,IsActive,CategoryProductId")] tb_Product tb_Product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_Product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_Product);
        }

        // GET: Admin/tb_Product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_Product tb_Product = db.tb_Product.Find(id);
            if (tb_Product == null)
            {
                return HttpNotFound();
            }
            return View(tb_Product);
        }

        // POST: Admin/tb_Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                tb_Product tb_Product = db.tb_Product.Find(id);
                db.tb_Product.Remove(tb_Product);
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
