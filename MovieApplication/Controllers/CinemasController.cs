using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApplication.Data;
using MovieApplication.Realizations.interfaces;

namespace MovieApplication.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;

        private readonly ICinemaInfo cinema;

        public CinemasController(AppDbContext appDbContext,ICinemaInfo info)
        {
            _context = appDbContext;
            cinema = info;

        }
        public  IActionResult Index()
        {
            var data =  cinema.Cinemas.ToList ();
            return View(data);
        }
    }
}
