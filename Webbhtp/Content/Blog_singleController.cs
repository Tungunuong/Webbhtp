using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webbhtp.Controllers;

namespace Webbhtp.Content
{
    public class Blog_singleController : Controller
    {
        // GET: Blog_single
        public ActionResult Index()
        {
            ViewBag.Blogsingle = new Blog_single().ListAll();

            return View();
        }
    }
}