using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models
{
    public class PriceApplicable
    {
       // public int productId { get; set; }

        public string productCode { get; set; }

        public string productName { get; set; }

        public string slogan { get; set; } //

       // public string productDescription { get; set; } //

        public decimal productNetPrice { get; set; }

        public decimal productSalesPrice { get; set; }

        public string promotionCode { get; set; }

        public string promotionName { get; set; }

        public string promotionDescription { get; set; }

   

        public decimal productPromotionPrice { get; set; }

        //public DateTime? startDate { get; set; }

        //public DateTime? endDate { get; set; }
    }
}
