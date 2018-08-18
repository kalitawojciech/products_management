using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsManagement.Models
{
    public class Products
    {
        
        public int ID { get; set; }
        
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Product_Name { get; set; }

        [Required]
        [StringLength(120, MinimumLength = 3)]
        public string Product_Description { get; set; }
        public int category_ID { get; set; }
        public double Products_Price { get; set; }

        public virtual Category Category { get; set; }
    }
}
