using Data.Models;
using System.Collections.Generic;

namespace PustokMVC.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Feature> Features { get; set; }
        public List<SimplePromotion> SimplePromotions { get; set; }
        public List<ComplexPromotion> ComplexPromotions { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
    }
}
