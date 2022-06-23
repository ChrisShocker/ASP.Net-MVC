using Microsoft.AspNetCore.Mvc;
using Vidly.Data;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        //create an instance of ApplicationDbContext to access the Db
        private ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }


        //_context is a temporary object
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        public IActionResult List()
        {
            //Entity defers the query until the customer object is actually iterated over ie, at View(customers)
            var customers = _context.Customers;

            return View(customers);
        }

        public IActionResult Details(int Id)
        {
            var customer = _context.Customers.SingleOrDefault(customer => customer.Id == Id); 

            return View(customer);
        }
    }
}
