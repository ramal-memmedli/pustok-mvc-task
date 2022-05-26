using Data.DAL;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using PustokMVC.ViewModels;
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
            HomeVM homeVM = new HomeVM();

            List<Slider> sliders = _context.Sliders.ToList();

            homeVM.Sliders = _context.Sliders.ToList();
            homeVM.Features = _context.Features.ToList();
            homeVM.SimplePromotions = _context.SimplePromotions.ToList();
            homeVM.ComplexPromotions = _context.ComplexPromotions.ToList();

            return View(homeVM);
        }
    }
}
