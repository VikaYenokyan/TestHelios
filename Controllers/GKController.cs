using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;

namespace MyCompany.Controllers
{
    public class GKController : Controller
    {
        private readonly DataManager dataManager;
        public GKController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index10(int id)
        {
            if (id != default)
            {
                return View("Show3", dataManager.GK.GetGKById(id));
            }
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageGK");
            return View(dataManager.GK.GetGKs());
        }

    }
}
