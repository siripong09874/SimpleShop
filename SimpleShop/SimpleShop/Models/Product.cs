using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShop.Models
{
    public class Product
    {
        public int id { get; set; }

        public string productCode { get; set; }

        public string productName { get; set; }

        public string slogan { get; set; } //

        public string productDescription { get; set; } //

        public decimal productNetPrice { get; set; }

        public decimal productSalesPrice { get; set; }

       // public decimal productSalesPriceWithVatRatio { get; set; }

    }
}
