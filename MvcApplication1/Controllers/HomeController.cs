using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;
using MvcApplication1.Models.Repository;
using System.Collections.ObjectModel;


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
        /*[HttpGet]
        public ActionResult Index(string title)
        {
            //string query = Request.QueryString["Foo"]; // Запрос в  адресной строке после знака?
            if (title == null)
            {
                title = "А. де Сент Экзепюри «Маленький принц»";
            }
            var readers = new DataReaders();
            return View( readers.GetHistory(title));
        }

        [HttpPost]
        //[ValidateInput(false)] // можно вводить html теги
        public ActionResult Index(History model)
       
        {
            var title = "А. де Сент Экзепюри «Маленький принц»";
            
            if (model.NewComment != null && ModelState.IsValid)
            
            {
                var readers = new DataReaders();
                readers.AddComment(title, model.NewComment.Comment);
                //CommentRepository.Comments.Add(model.NewComment.Comment);
                ModelState.Clear();
                return View(readers.GetHistory(title));
            }

            return View(model);
        }*/
         [HttpGet]
        public ActionResult Index(string title)
        {
            
            if (title == null)
            {
                title = "А. де Сент Экзепюри «Маленький принц»";
            }
            using (var ctx = new EFContext())
            {
                var post = ctx.Posts.Where(p => p.Title == title).FirstOrDefault();
                var postModel = new PostModel(post.Title, post.Body, post.DateCreated);
                var commentModel = new Collection<string>();
                if (post.Comments != null && post.Comments.Any())
                {
                    foreach (var item in post.Comments)
                    {
                        commentModel.Add(item.Body);
                    }
                }

                return View(new History(postModel, commentModel));
            }
            
        }

        [HttpPost]
        //[ValidateInput(false)] // можно вводить html теги
        public ActionResult Index(History model)
       
        {
            var title = "А. де Сент Экзепюри «Маленький принц»";
            
            if (model.NewComment != null && ModelState.IsValid)
            
            {
                using (var ctx = new EFContext())
                {
                    var post = ctx.Posts.Where(p => p.Title == title).FirstOrDefault();
                    if (post != null)
                    {
                        ctx.Comments.Add(new Comment() { Body = model.NewComment.Comment, PostID = post.PostID });
                        ctx.SaveChanges();
                    }
                }
                ModelState.Clear();
                return RedirectToAction("Index", new { title = title });
            }

            return View(model);
        }
    }
}
