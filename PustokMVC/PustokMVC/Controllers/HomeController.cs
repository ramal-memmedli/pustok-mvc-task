using Data.DAL;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace PustokMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            return View(sliders);
        }
    }
}
