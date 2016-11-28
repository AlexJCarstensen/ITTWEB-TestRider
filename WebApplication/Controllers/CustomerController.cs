using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;
using WebApplication.ViewModels;

namespace WebApplication.Controllers
{
    public class CustomerController :  Controller
    {
        //[HttpGet("api/test/cust")]
        public IActionResult Customers()
        {



            var viewModel = new CustomersViewModel
            {
                Customers = CustomerMock.GetCustomers()
            };

            return View(viewModel);
        }
        public IActionResult Details(int foo)
        {
            var customer = CustomerMock.GetCustomers().Find(x => x.Id == foo);

            return View(customer);
        }
    }
}