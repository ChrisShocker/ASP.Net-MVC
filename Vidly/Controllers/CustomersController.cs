using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {

        public IActionResult List()
        {
            //Create some customers to pass to the View
            var customers = new List<Customer>
            {
                new Customer { Name = "Gerald", Id = 1 },
                new Customer { Name = "Harry", Id = 2}
            };


            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        public IActionResult Details(int Id)
        {

            var customers = new List<Customer>
            {
                new Customer { Name = "Gerald", Id = 1 },
                new Customer { Name = "Harry", Id = 2}
            };

            foreach(var customer in customers)
            {
                if(customer.Id == Id)
                    return View(customer);
            }

            return View(customers);
        }
    }
}
