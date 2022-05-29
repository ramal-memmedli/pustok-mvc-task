using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public string Image { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
        public double DiscountPrice { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
