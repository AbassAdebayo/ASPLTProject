using Microsoft.AspNetCore.Mvc;
using TestWEbApi2.CustomerDto;
using TestWEbApi2.Interface;

namespace TestWEbApi2.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            
            return View(_customerService.ListOfCustomers());
        }


        public IActionResult CreateCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCustomer(CreateCustomerRequestModel model)
        {
            _customerService.CreateCustomer(model);
            TempData["message"] = $"You have sucessfully created a customer with the name {model.CustomerName}";
            TempData.Keep();
            return RedirectToAction("Index","Home");
        }

    }
}
