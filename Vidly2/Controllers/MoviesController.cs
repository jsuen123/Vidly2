using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;
using Vidly2.ViewModels;

namespace Vidly2.Controllers
{
    public class MoviesController : Controller
    {
        private List<Movie> _movies;

        public MoviesController()
        {
            _movies = new List<Movie>()
            {
                new Movie(){Name = "Shrek!", Id = 1},
                new Movie(){Name = "Wall-e", Id = 2},
            };
        }

        // GET: Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>()
            {
                new Customer() {Name = "Customer 1"},
                new Customer() {Name = "Customer 1"},
                new Customer() {Name = "Customer 1"},
                new Customer() {Name = "Customer 1"},
                new Customer() {Name = "Customer 1"},
                new Customer() {Name = "Customer 1"},

            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Index()
        {
            return View(_movies);
        }

        public ActionResult Details(int id)
        {
            return View(_movies.FirstOrDefault(m=>m.Id==id));
        }
    }
}