using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models
{
    public class Promotion
    {
        public int id {get; set;}
        public string promotionCode { get; set; }

        public string promotionName { get; set; }

        public string promotionDescription { get; set; }

        public int productId { get; set; }

        public decimal productPromotionPrice { get; set; }

        public DateTime startDate { get; set; }

        public DateTime endDate { get; set; }


    }
}
