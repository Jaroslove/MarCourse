using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarCourse.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            var movie = new Models.Movie { Name = "Shreck" };

            var customers = new List<Models.Customer>
            {
                new Models.Customer{Name = "One"},
                new Models.Customer{Name = "Two"}
            };

            var viewModel = new ViewModel.RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        //[Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]//mvc5
        [Route("movies/released/{year}/{month:regex(\\d{4})}")]//mvc5
        public ActionResult ByRealiseDate(int year, int month)
        {
            return Content($"year {year} month {month}");
        }
    }
}