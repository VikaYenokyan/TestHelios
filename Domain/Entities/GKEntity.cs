using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Domain.Entities
{
    public class GKEntity : EntityBase
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Display(Name = "Название ЖК")]
        public string Name { get; set; }
        [Display(Name = "Регион")]
        public string Region { get; set; }
        [Display(Name = "Округ")]
        public string District { get; set; }
        [Display(Name = "Район")]
        public string Area { get; set; }
        [Display(Name = "Улица")]
        public string Street { get; set; }
        [Display(Name = "Дом")]
        public int Num { get; set; }
        public int ID_Builder { get; set; }
    }
}
