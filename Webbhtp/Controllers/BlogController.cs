using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webbhtp;
using PagedList;
using System.Runtime.Remoting.Messaging;

namespace Webbhtp.Controllers
{
    public class BlogController : Controller
    {
        BanHangThucPhamEntities myObj = new BanHangThucPhamEntities();

        public ActionResult Index(int? pageNumber)
        {
            if (pageNumber == null) pageNumber = 1;
            int pageSize = 3;
            var blog = myObj.tb_Blog;
            return
            View(blog.Where(j => (bool)j.IsActive).ToList().OrderBy(i => i.CreatedDate).ToPagedList((int)pageNumber,
            pageSize));
        }

        public ActionResult Blogs_detail(int? idbv)
        {
            if (idbv == null)
            {
                return HttpNotFound();
            }
            else
            {
                var items = myObj.tb_Blog.Find(idbv);
                return View("Details", items);
            }
        }
        public ActionResult Blogs_other(int id)
        {
            var items = myObj.tb_Blog.Where(i => (bool)i.IsActive).Where(j => j.BlogId != id).ToList();
            return PartialView("Blogs_other", items);
        }
        public ActionResult Comment(int id)
        {
            var item = myObj.tb_Comment.Where(i => i.BlogId == id).ToList();
            ViewBag.count=item.Count();
            return PartialView("Comment", item);
        }
        [HttpPost]
        public ActionResult AddComment(int Id, string Name, string Content)
        {
            tb_Comment cmt = new tb_Comment()
            {
                BlogId = Id,
                Name = Name,
                Content = Content,
                Date= DateTime.Now,
            };
            myObj.tb_Comment.Add(cmt);
            myObj.SaveChanges();
            return Redirect(url: Request.UrlReferrer.ToString());
        }
    }
}