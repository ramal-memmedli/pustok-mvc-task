using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class SimplePromotion : BaseEntity
    {
        public string RedirectUrl { get; set; }
        public string Image { get; set; }
    }
}
