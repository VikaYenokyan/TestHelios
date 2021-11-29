using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MyCompany.Domain;

namespace MyCompany.Domain.Entities
{
    public class EntityBase
    {
      

        [Display(Name ="Название (заголовок)")]
        public virtual string Title { get; set; }

        [Display(Name = "Полное описание")]
        public virtual string Text { get; set; }
        public virtual string TitleImagePath { get; set; }
      
       
    }
}
