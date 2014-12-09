using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class CommentsItemModel
    {
        public CommentsItemModel()
        {
            Username = "Rika";
            Comment = "Comment_comment";
            Date = DateTime.Now;
        }

        public string Username { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }

    }
}