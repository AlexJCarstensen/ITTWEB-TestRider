using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;
using WebApplication.ViewModels;

namespace WebApplication.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Movies()
        {
            var viewModel = new MoviesViewModel()
            {
                Movies = MoviesMock.GetMovies()
            };

            return View(viewModel);

        }
    }
}