using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class AddCommentModel
    {
        [Required(ErrorMessage = "Пожалуйста, введите {0}")]
        [Display(Name = "Комментарий")]
        [StringLength(100)] // максимальная длина строки
        //[RegularExpression(@"\d+")] 
        public string Comment { get; set; }

        [Range(1,100)]
        public int? Age { get; set; }
        //public UserModel User { get; set; }

        
    }
}