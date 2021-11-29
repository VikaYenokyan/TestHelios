using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;
using MyCompany.Domain.Model;
using MyCompany.Domain.Entities;

namespace MyCompany.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CustomerController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostEnvironment;
        public CustomerController(DataManager dataManager)
        {
            this.dataManager = dataManager;
            this.hostEnvironment = hostEnvironment;
        }

        public IActionResult Index8(int id)
        {
            if (id != default)
            {
                return View("Show2", dataManager.Customer.GetCustomerById(id));
            }
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageForCall");
            return View(dataManager.Customer.GetCustomers());
        }

        public IActionResult Edit3(int id)
        {
            var entity = id == default ? new CustomerEntity() : dataManager.Customer.GetCustomerById(id);
            return View("Tuple");

            
        }
    }
}
