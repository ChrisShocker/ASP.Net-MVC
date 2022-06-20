﻿using Microsoft.AspNetCore.Mvc;
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

        //ViewResult returns a View upon request

        //IActionResult is the base class for all 'Results', use it to return any Result
        public IActionResult Random()
        {
            var movie = new Movie("SomeMovie");

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

            //Return a view method that's inherited from base Controller class
            return View(movie);
        }
    }
}
