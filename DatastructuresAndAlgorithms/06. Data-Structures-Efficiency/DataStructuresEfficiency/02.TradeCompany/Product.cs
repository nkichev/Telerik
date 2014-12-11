using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TradeCompany
{
    public class Product : IComparable<Product>
    {
        public Product(string barCode, string vendor, string title, int price)
        {
            this.BarCode = barCode;
            this.Vendor = vendor;
            this.Title = title;
            this.Price = price;
        }

        public string BarCode { get; set; }

        public string Vendor { get; set; }

        public string Title { get; set; }

        public int Price { get; set; }

        public int CompareTo(Product other)
        {
            return this.Price.CompareTo(other.Price);
        }
    }
}
