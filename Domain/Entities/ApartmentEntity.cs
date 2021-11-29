using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Domain.Entities
{
    public class ApartmentEntity 
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Display(Name="Регион")]
        public string Region { get; set; }
        [Display(Name = "Округ")]
        public string District { get; set; }
        [Display(Name = "Район")]
        public string Area { get; set; }
        [Display(Name = "Улица")]
        public string Street { get; set; }
        [Display(Name = "Номер дома/номер квартиры")]
        public int Num { get; set; }
        [Display(Name = "Площадь")]
        public int Square { get; set; }
        [Display(Name = "Количество комнат")]
        public int Rooms { get; set; }
        [Display(Name = "Этаж/количество этажей")]
        public int Floor { get; set; }
        [Display(Name = "Стоимость")]
        public int Price { get; set; }
        [Display(Name = "Продажа/Аренда")]
        public string Type_price { get; set; }
        [Display(Name = "Квартира/Дом")]
        public string Type_apart { get; set; }
        public virtual string TitleImagePath { get; set; }
        public int ID_Realtor { get; set; }
        public int? ID_GK { get; set; }
    }
}
