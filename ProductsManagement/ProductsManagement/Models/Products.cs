using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsManagement.Models
{
    public class Products
    {
        public int Products_ID { get; set; }
        public string Product_Name { get; set; }
        public string Product_Description { get; set; }
        public int category_ID { get; set; }
        public double Products_Price { get; set; }
    }
}
