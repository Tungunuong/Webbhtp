using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webbhtp.Controllers;
using Webbhtp;
using System.Xml.Linq;
using System.Net;

namespace Webbhtp.Content
{
    public class ShopController : Controller
    {
        // GET: Shop
        BanHangThucPhamEntities myObj = new BanHangThucPhamEntities();



        // GET: Category
        public ActionResult Index()
        {

            ViewBag.Product = new Productshop().ListAll();

            return View();
        }
        public ActionResult Menushop()
        {
            var item = myObj.tb_CategoryProduct.Where(i => i.IsActive).ToList();
            return PartialView("Menushop", item);
        }

        public ActionResult Details(int? id)
        {
        
            if (id == null) return HttpNotFound();
            else
            {
                var items = myObj.tb_Product.Find(id);
                return View("Details", items);
            }

            var item = myObj.tb_Product.Where(i => i.IsActive).Where(j => j.IsHome == true).ToList();
            return PartialView("ProductHome", item);
        }
        public ActionResult Other(int id)
        { tb_Product sp = myObj.tb_Product.Find(id);
            int cpid = (int)sp.CategoryProductId;
            var item = myObj.tb_Product.Where(i => i.ProductdID != id).Where(j => j.CategoryProductId == cpid).ToList();
            return PartialView("Other",item);
        }
    }
}
