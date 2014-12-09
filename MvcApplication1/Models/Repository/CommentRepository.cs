//using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
//using System.Linq;
//using System.Web;

namespace MvcApplication1.Models.Repository
{
    public static class CommentRepository
    {
        public static readonly ICollection<string> Comments = new Collection<string>();
    }
}