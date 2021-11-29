using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;

namespace MyCompany.Controllers
{
    public class BuilderController : Controller
    {
        private readonly DataManager dataManager;
        public BuilderController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index6(int id)
        {
            if (id != default)
            {
                return View("Show1", dataManager.Builder.GetBuilderById(id));
            }
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageBuilder");
            return View(dataManager.Builder.GetBuilders());
        }

        public IActionResult Index7(int id)
        {
            if (id != default)
            {
                return View("Show1", dataManager.Builder.GetBuilderById(id));
            }
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageBuilder");
            return View(dataManager.Builder.GetBuilders());
        }

    }
}
