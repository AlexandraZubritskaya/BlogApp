using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class RecentComments
    {
        public RecentComments() {

            URL = "Bla";
            Text = "Comment";
            Date = DateTime.Now;
            ID = 9009;

        }
        public int ID { get; set; }
        public string Text { get; set; }
        public string URL { get; set; }
        public DateTime Date { get; set; }
    }
}