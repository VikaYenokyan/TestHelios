using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;

namespace MyCompany.Controllers
{
    public class ApartmentsBuyController : Controller
    {
        private readonly DataManager dataManager;
        public ApartmentsBuyController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index4(int id)
        {
            if (id != default)
            {
                return View("Show", dataManager.Apartments.GetApartmentById(id));
            }
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageApartmentsBuy");
            return View(dataManager.Apartments.GetApartments());
        }

        public IActionResult Index5(int id)
        {
            if (id != default)
            {
                return View("Show", dataManager.Apartments.GetApartmentById(id));
            }
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageApartmentsBuy");
            return View(dataManager.Apartments.GetApartments());
        }
    }
}
