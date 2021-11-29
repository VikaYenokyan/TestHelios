using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;

namespace MyCompany.Controllers
{
    public class MyAccountController : Controller
    {
        private readonly DataManager dataManager;
        public MyAccountController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index8(int id)
        {
            if (id != default)
            {
                return View("Show", dataManager.Apartments.GetApartmentById(id));
            }
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageMyAccount");
            return View(dataManager.Apartments.GetApartments());
        }

        
    }
}
