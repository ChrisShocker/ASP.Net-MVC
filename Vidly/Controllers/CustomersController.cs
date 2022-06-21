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
                new Customer { Name = "Gerald" },
                new Customer { Name = "Harry"}
            };



            //create a viewModel object that will hold the customers
            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };


            //Pass the viewModel to the View for rendering
            return View(viewModel);
        }
    }
}
