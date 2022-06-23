using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        /*
         * Eager Loading
         * - By default Entity won't load related objects ie, MembershipType isn't loaded and will through an error
         *   even though it's a related object to Customer
         *   
         * We can load related queryr objects by Including a reference to the related object ie, 'Include(c => c.MembershipType)'
         *
         * https://docs.microsoft.com/en-us/ef/core/querying/related-data/eager
         */

        public IActionResult List()
        {
            //Entity defers the query until the customer object is actually iterated over ie, at View(customers)
            var customers = _context.Customers.Include(c => c.MembershipType);

            return View(customers);
        }

        public IActionResult Details(int Id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(customer => customer.Id == Id); 

            return View(customer);
        }
    }
}
