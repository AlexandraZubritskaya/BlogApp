using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class CommentController : Controller
    {
        //
        // GET: /Comment/

        //public ActionResult Recent()
        //{
        //    var model = new CommentsModel();
        //   return View(model);
        //}

        //public ContentResult GetByUrl(string seoUrl)
        //{
        //   return new ContentResult() { Content = "#" + seoUrl + "#" }; 
        //           }
         public ContentResult Index()
         {
            return new ContentResult() { Content = "Hello" };
        }
    }
}
