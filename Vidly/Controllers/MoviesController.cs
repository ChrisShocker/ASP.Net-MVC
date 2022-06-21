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

    public class MoviesController : Controller
    {

        //ViewResult returns a View upon request

        //IActionResult is the base class for all 'Results', use it to return any Result
        public IActionResult Random()
        {
            /******************************************************/
            //Controller action types

            //Return a string
            //return Content("Hello World");

            //Return nothing
            //return new EmptyResult();

            /*
             * Return a redirect to a different page
             * - 1st arg is Action
             * - 2nd is controller
             * - 3rd are arguments sent to the targeted action
             */
            //return RedirectToAction("Index", "Home", new {page = 1, sortBy = "Name"});
            /******************************************************/



            /******************************************************/
            //Passing Data:

            /*
             * 1. ViewData approach
             * create a ViewData object from the view dictionary
             * 
             * ViewData["Movie"] = movie;
             * 
             * Note: The magic string makes this code fragile 
             */

            /*
             * 2. ViewBag approach
             * create a ViewBag with a magic property
             * - property is added at runtime
             * - No Compile time safety
             * 
             * Viewbag.Movie = movie;
             * 
             * Note: The magic parameter 'Movie' makes this code fragile 
             */

            /*
             * 3. Object approach
             * - Best approach 
             * 
             */

            //create a movie object
            var movie = new Movie("SomeMovie");
            return View(movie);



        }

        /*
         * Get URL Argument and return
         * - ie: https://localhost:7009/Movie/Edit/1
         * 
         * Get URL query and return it
         * - ie: https://localhost:7009/Movie/Edit?id=1
         *  - Note query string paramters must match what's being returned to client
         */

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        /*
         * return movie list from db
         *  - display page 1 movies if pageIndex isn't set
         *  - sortby movie Name if sortBy name
         */
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (pageIndex == null)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            /*
             * Return a string with whatever is passed in the arguments
             *  - ie: https://localhost:7009/Movie?pageIndex=2&sortBy=ReleaseDate
             *  - returns: pageIndex = 2 & sortBy=ReleaseDate
             */
            return Content(String.Format("pageIndex = {0} & sortBy={1}", pageIndex, sortBy));
        }

        /*
         * Custom Routes using Attribute Routing
         * - More powerful version of custom routing
         *
         * https://docs.microsoft.com/en-us/aspnet/web-api/overview/web-api-routing-and-actions/attribute-routing-in-web-api-2
         * 
         * Note: Range is an attribute route contstraint
         */
        [Route("movies/released/{year}/{month:int:range(1, 12)}")]

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}
