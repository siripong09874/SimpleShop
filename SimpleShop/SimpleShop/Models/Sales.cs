using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models
{
    public class Sales
    {
        public string productCode { get; set; }

        public string productName { get; set; }
        public decimal productPrice { get; set; }
        public int productAmount { get; set; }


        public decimal? productPromotionDiscountSalesPrice { get; set; }

        public decimal salesPrice
        {


            get
            {
                decimal value;
                if (productPromotionDiscountSalesPrice.HasValue)
                    value = this.productPromotionDiscountSalesPrice.Value;
                else
                    value = productPrice;



                return value;
            }

        }

        public decimal totalPrice
        {
            get
            {
                decimal value;

                value = (salesPrice * productAmount);


                return value;
            }
        }
    }
}
