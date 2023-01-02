using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webbhtp;

namespace Webbhtp.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        // public ActionResult Index()
        // {
        //    ViewBag.News = new News().ListAll();

        //   return View();
        // }
        BanHangThucPhamEntities myObj = new BanHangThucPhamEntities();

        public ActionResult Index(int? pageNumber)
        {
            if (pageNumber == null) pageNumber = 1;
            int pageSize = 3;
            var news = myObj.tb_News;
            return
            View(news.Where(j => (bool)j.IsActive).ToList().OrderBy(i => i.CreatedDate));
        }

        public ActionResult News_detail(int? idbv)
        {
            if (idbv == null)
            {
                return HttpNotFound();
            }
            else
            {
                var items = myObj.tb_News.Find(idbv);
                return View("Details", items);
            }
        }
        public ActionResult News_other(int id)
        {
            var items = myObj.tb_News.Where(i => (bool)i.IsActive).Where(j => j.NewsId != id).ToList();
            return PartialView("News_other", items);
        }

    }
}