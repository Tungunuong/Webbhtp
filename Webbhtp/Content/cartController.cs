﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Webbhtp.Content
{
    public class cartController : Controller
    {
        // GET: cart
        public ActionResult Index()
        {
            return View();
        }
    }
}