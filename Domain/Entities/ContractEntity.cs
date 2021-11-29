using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Domain.Entities
{
    public class ContractEntity
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Display(Name = "Дата начала бронирования")]
        public DateTime Date_1 { get; set; }
        [Display(Name = "Дата окончания бронирования")]
        public DateTime Date_2 { get; set; }
        public int ID_Apartments { get; set; }
        public int ID_Customer { get; set; }
    }
}
