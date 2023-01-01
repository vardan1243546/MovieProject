using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApplication.Data;
using MovieApplication.Realizations.interfaces;

namespace MovieApplication.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        private readonly IMovieInfo movieInfo;
        public MoviesController(AppDbContext context,IMovieInfo info)
        {
            _context = context;
            movieInfo = info;
        }
        public  IActionResult  Index()
        {
            var data = movieInfo.Movies.ToList ();
            return View(data);
        }
    }
}
