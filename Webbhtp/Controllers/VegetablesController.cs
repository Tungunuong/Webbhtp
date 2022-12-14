using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Webbhtp.Controllers
{
    public class VegetablesController : Controller
    {
        // GET: Vegetables
        public ActionResult Index()
        {
            return View();
        }

        public class Vegetables
        {
            BanHangThucPhamEntities db = null;
            public Vegetables()
            {
                db = new BanHangThucPhamEntities();
            }

         
        }
    }
}