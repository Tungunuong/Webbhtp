﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Webbhtp.Controllers
{   
    public class HomeController : Controller
    {   
        private BanHangThucPhamEntities db = new BanHangThucPhamEntities();
        public ActionResult Index()
        {
            ViewBag.Slides = new Slidehome().ListAll();
            ViewBag.Producthome = new Producthome().ListAll();
            return View();
        }

       

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        BanHangThucPhamEntities lab = new BanHangThucPhamEntities();
        public ActionResult TopMenu()
        {
            var item = lab.tb_Menu.Where(i => i.IsActive).ToList();
            return PartialView("TopMenu", item);
        }

    }
}