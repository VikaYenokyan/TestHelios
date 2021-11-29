using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;
using MyCompany.Domain.Entities;

namespace MyCompany.Controllers
{
    public class ForCallController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostEnvironment;
        public ForCallController(DataManager dataManager)
        {
            this.dataManager = dataManager;
            this.hostEnvironment = hostEnvironment;
        }



        public IActionResult Edit3(int id)
        {
            var entity = id == default ? new CustomerEntity() : dataManager.Customer.GetCustomerById(id);
            return View(entity);
        }

     

    }
}
