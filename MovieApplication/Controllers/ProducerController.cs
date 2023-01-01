using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApplication.Data;
using MovieApplication.Realizations.interfaces;

namespace MovieApplication.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;
     
        private readonly IProducerInfo producer;

        public ProducersController(AppDbContext context,IProducerInfo info)
        {
            _context = context;
            producer = info;
        }
        public IActionResult Index()
        {
            var data=producer.Producers.ToList();
            return View(data);
        }
    }
}
