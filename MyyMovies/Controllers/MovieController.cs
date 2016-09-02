using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyyMovies.Models;
using MyyMovies.ViewModel;

namespace MyyMovies.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var obj = new Movie()
            {
                Name = "3 Idiots !!!!!!!"
            };

            var customers = new List<Customer>
            {
                new Customer {Name = " John" },
                new Customer { Name = " Maria" }
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = obj,
                Customers = customers
            };


            return View(viewModel);


 //--------------------------------------------------------------------------------------------------------
            //ViewBag.Movie = obj;
            //ViewData["Movie"] = obj;

            // return Content("Hello ASP.NET MVC");

            // return HttpNotFound();
            //return new EmptyResult();
            // return RedirectToAction("Index", "Home");
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id );
        }

        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}