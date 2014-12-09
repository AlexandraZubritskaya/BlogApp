using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class UserModel
    {
        public string Username { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public ICollection<string> Countries
        {
            get {
                return Repository.CountriesRepository.Countries;
            }
        }

        public HttpPostedFileWrapper Avatar { get; set; }
    }
}