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


                //if the customer exists
                if (uniqueCustomer.Count > 0)
                {
                    //create a viewModel object that will hold the customers
                    var viewModelUnique = new CustomersViewModel
                    {
                        Customers = uniqueCustomer
                    };

                    //Pass the viewModel to the View for rendering
                    return View(viewModelUnique);
                }

                //customer not found
                else
                {
                    var notFound = new List<Customer>
                    {
                        new Customer { Name = "Customer Not Found"}
                    };

                    var NotFoundViewModel = new CustomersViewModel
                    {
                        Customers = notFound
                    };

                    return View(NotFoundViewModel);
                }
            }

            //No Arguments passed in return the current list of customers
            else
                return View(viewModel);
        }
    }
}
