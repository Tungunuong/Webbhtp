using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webbhtp.Controllers;

namespace Webbhtp.Content
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            ViewBag.Blog = new Blog().ListAll();
            return View();
        }
    }
}