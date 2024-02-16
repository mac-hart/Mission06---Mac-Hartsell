using Microsoft.AspNetCore.Mvc;
using Mission06.Models;
using System.Diagnostics;

namespace Mission06.Controllers
{
    public class HomeController : Controller
    {

        private MovieContext _movieContext;
        public HomeController(MovieContext temp)
        {
            _movieContext = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        [HttpGet]

        public IActionResult SubmitMovie()
        {
            return View("SubmitMovie");
        }

        [HttpPost]

        public IActionResult SubmitMovie(SubmitMovie response)
        {

            _movieContext.Movies.Add(response); //add record to database
            _movieContext.SaveChanges();

            return View("Confirmation", response);
        }



    }
}
