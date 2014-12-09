using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class CommentsModel
    {
        public CommentsModel() 
        {
            Items = new Collection<RecentComments>();
            Items.Add(new RecentComments());
            Items.Add(new RecentComments());
            Items.Add(new RecentComments());
        }
        public ICollection<RecentComments> Items { get; set; }
    }
}