﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Admin/Home/

        public ContentResult Index()
        {
            return new ContentResult() { Content = "Administrative Area" };
        }
        //public ActionResult Index()
        //{
        //    return View();
        //}

    }
}
