using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class HomeMode 
    {
        public HomeMode()
        {
            Pelmeni = new History();
          
        }
        public History Pelmeni { get; set; }
        //public CommentsModel RecentComments { get; set; }

    }
}