using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {

        public IActionResult List(int Id)
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

            //If an Id is passed in
            if (Id != 0)
            {
                var uniqueCustomer = new List<Customer>();
                foreach (var customer in customers)
                {
                    if (customer.Id == Id)
                        uniqueCustomer.Add(customer);
                }

                var uniqueViewModel = new CustomersViewModel
                {
                    Customers = customers
                };

                return View(uniqueViewModel);
            }

            //No Arguments passed in return the current list of customers
            else
                return View(viewModel);
        }
    }
}
