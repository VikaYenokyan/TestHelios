using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Domain.Entities
{
    public class RealtorEntity
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Display(Name = "ФИО")]
        public string Name { get; set; }
        [Display(Name = "Стаж работы")]
        public int Work { get; set; }
        [Display(Name = "Контакты")]
        public long Contact { get; set; }
    }
}
