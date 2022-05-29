using Data.DAL;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

            homeVM.Sliders = _context.Sliders.Where(n => !n.IsDeleted).ToList();
            homeVM.Features = _context.Features.Where(n => !n.IsDeleted).ToList();
            homeVM.SimplePromotions = _context.SimplePromotions.Where(n => !n.IsDeleted).ToList();
            homeVM.ComplexPromotions = _context.ComplexPromotions.Where(n => !n.IsDeleted).ToList();
            homeVM.Categories = _context.Categories.Where(n => !n.IsDeleted).ToList();
            homeVM.Products = _context.Products.Where(n => !n.IsDeleted).Include(x => x.Category).ToList();

            return View(homeVM);
        }
    }
}
