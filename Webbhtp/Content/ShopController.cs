using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webbhtp.Controllers;

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
    }


}
