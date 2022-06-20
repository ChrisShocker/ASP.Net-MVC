using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{

    /*
     * Controller Actions:
     * - We can respond to requests made to MVC with different controller actions
     * 
     * Controller Action Types: 
     * https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/controllers-and-routing/aspnet-mvc-controllers-overview-cs
     * 
     * 
     * Action Type Base class: IActionResult
     * - Used when multiple ActionResults return types are possible
     * 
     * https://docs.microsoft.com/en-us/aspnet/core/web-api/action-return-types?view=aspnetcore-6.0
     */

    public class MovieController : Controller
    {
        //IActionResult is the base class for all IActionResults 
        //public IActionResult Random()

        //We can use ViewResult since we're returning a View upon request
        public ViewResult Random()
        {
            var movie = new Movie("SomeMovie");

            //Return a view method that's inherited from base Controller class
            return View(movie);
        }
    }
}
