using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidley.Models;
using vidley.ViewModels;

namespace vidley.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shreck" };
            List<Customer> customers = new List<Customer>
            {
                new Customer{ Name = "Customer 1"},
                new Customer{ Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
            //return Content("Movie");
            //return new EmptyResult();
        }
        //[Route("movies/released/{year}/{month:regex(\\d{2}):range(1-12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year+ "/" + month);
        }
        public ActionResult Edit(int id)
        {
            return Content("ID: " + id);
        }
        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "name";
                return Content(String.Format("Page Index= {0} & Sort By = {1} ", pageIndex, sortBy));
        }
    }
}