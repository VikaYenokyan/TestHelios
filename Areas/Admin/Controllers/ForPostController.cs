using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;
using MyCompany.Domain.Entities;
using MyCompany.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;


namespace MyCompany.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ForPost1Controller : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostEnvironment;
        public ForPost1Controller(DataManager dataManager, IWebHostEnvironment hostEnvironment)
        {
            this.dataManager = dataManager;
            this.hostEnvironment = hostEnvironment;
        }

        public IActionResult Edit2(int id)
        {
            var entity = id == default ? new ApartmentEntity() : dataManager.Apartments.GetApartmentById(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit2(ApartmentEntity model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.TitleImagePath = titleImageFile.FileName;
                    using (var stream = new FileStream(Path.Combine(hostEnvironment.WebRootPath, "images/", titleImageFile.FileName), FileMode.Create))
                    {
                        titleImageFile.CopyTo(stream);
                    }

                }
                dataManager.Apartments.SaveApartmentEntity(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
        public IActionResult Index9(ApartmentEntity model)
        {
            if (model.ID != default)
            {
                return View("Show", dataManager.Apartments.GetApartmentById(model.ID));
            }
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageApartmentsBuy");
            return View(dataManager.Apartments.GetApartments());
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            dataManager.Apartments.DeleteApartmentEntity(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}
