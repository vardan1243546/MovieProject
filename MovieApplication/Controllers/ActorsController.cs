using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using MovieApplication.Data;
using MovieApplication.Models;
using MovieApplication.Realizations.interfaces;
using MovieApplication.Services.Repository;

namespace MovieApplication.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;

        private readonly IActorInfo  actorInfo;

        private readonly IActorRepository actor;
     
        public ActorsController(AppDbContext context,IActorInfo actorInfo, IActorRepository actor)
        {
            this.actorInfo = actorInfo;
            this.actor = actor;
            _context = context;
        }
        public  IActionResult Index()
        {
            var data =  actor.GetAll();
            _context.SaveChanges();
            return View(data);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Actor model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

           actor.Add(model);
            return RedirectToAction("Index");
        }

        //[HttpPost]

        //public async Task<IActionResult> Details(int id)
        //{
        //    var actorDetails = actor.GetAll();
        //}
    }
}
