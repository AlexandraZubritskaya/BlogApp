﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using MvcApplication1.Models.Repository;

namespace MvcApplication1.Models
{
    public class History

    {
        public History() 
        {
            Title = "Пельмени по-китайски";
            Username = "Sasha";
            Body = "Китайцы любят пельмени – цзяо-цзы 饺子. Они готовят их дома или едят в столовых и ресторанах. "+
            "Жители Северного Китая считают цзяо-цзы своей национальной едой. Они были известны в Китае уже в эпоху "+
            "Троецарствия (三国, 220-280). На китайский Новый год (Праздник Весны) есть традиция всей семьей собираться вместе,"+
            " лепить и есть пельмени. На юге угощением является сладкий рис, приготовленный особым образом. Подают цзяо-цзы и тогда, "+
            "когда провожают в дальнюю дорогу сына. Это связано с тем, что по-китайски цзяо-цзы 饺子 (jiǎo-zi) звучит почти как цзяо цзы "+
            "叫子 (jiào zi) — «звать сына». <p>Цзяо-цзы во многом напоминают наши российские пельмешки. Порой их лепят с кокетливыми волнистыми краями."+
            " Тонкое тесто делается из муки и воды. Начинка может быть самой разной: мясной (из одного или двух-трех видов мяса), из мяса с овощами "+
            "(например, свинины с капустой или кукурузой). Чисто овощной, грибной, рисовой, из морепродуктов или «сборной». Очень популярны цзяо-цзы "+
            "с начинкой из вареного яйца и зеленого лука. Вкусны пельмени из яйца и укропа или иной зелени. Китайские пельмени варятся "+
            "в кипящей воде или на пару. Их могут жарить в масле (обычно используют растительное). Размер цзяо-цзы может быть самым разным."+
            " Китайцы иногда делают парные цзяо-цзы длиной в 15-18 см.</p>";
            Date = DateTime.Now;
            //Comments = new Collection<CommentsItemModel>();

        }
        public string Title {get; set;}
        public string Body { get; set; }
        
        public DateTime Date { get; set; }
        public string Username { get; set; }
        //public ICollection<CommentsItemModel> Comments { get; set; }
        public ICollection<string> Comments
        {
            get {
                return CommentRepository.Comments;
            }
        
        }
        public AddCommentModel NewComment { get; set; }
    }
}