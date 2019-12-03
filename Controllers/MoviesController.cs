using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // This allows us to return the list of movies to the view.
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            // Movies are hardcoded for now, Entity Frameworks will be used later.
            return new List<Movie>
            {
                new Movie { ID = 1, Name = "The Matrix" },
                new Movie { ID = 2, Name = "Dragon Ball Super: Broly" }
            };
        }
    }
}