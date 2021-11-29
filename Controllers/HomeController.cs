using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;

namespace MyCompany.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageApartmentsArenda"));
        }

        public IActionResult Index1()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageApartmentsBuy"));
        }


        public IActionResult Contacts()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageContacts"));
        }

        public IActionResult MyAccount()
        { 
            return View(dataManager.TextFields.GetTextFieldByCodeWord("PageMyAccount"));
        }
    }
}
