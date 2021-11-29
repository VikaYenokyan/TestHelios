using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Domain.Entities
{
    public class BuilderEntity : EntityBase
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Display(Name = "Название")]
        public string Name { get; set; }
        [Display(Name = "Стаж работы")]
        public DateTime Year { get; set; }
        [Display(Name = "Количество сданных домов")]
        public int Rented { get; set; }
        [Display(Name = "Количество строящихся домов")]
        public int Build { get; set; }
    }
}
