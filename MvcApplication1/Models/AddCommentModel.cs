using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class AddCommentModel
    {
        public string Comment { get; set; }
        public UserModel User { get; set; }
    }
}