using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;
using MvcApplication1.Models.Repository;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        // public ActionResult AddComment()
        //{
        //    string comment = Request.Form["Comment"];
        //    return RedirectToAction("Index", "Home");
        //}

        //public ActionResult AddComment(string comment)
        //{
            
        //    return RedirectToAction("Index", "Home");
        //}
        //[HttpPost]
       // public ActionResult AddComment(AddCommentModel model)
       // {
       //     return RedirectToAction("index", "home");
        //}
        [HttpGet]
        public ActionResult Index()
        {
            string query = Request.QueryString["Foo"]; // Запрос в  адресной строке после знака?
            var model = new History();
            return View(model);
        }

        [HttpPost]
        [ValidateInput(false)] // можно вводить html теги
        public ActionResult Index(History model)
        {
            if (model.NewComment != null && ModelState.IsValid)
            
            {
                CommentRepository.Comments.Add(model.NewComment.Comment);
            }
            return View(new History());
        }
    }
}
