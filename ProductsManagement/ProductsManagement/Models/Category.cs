using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsManagement.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Category_Name { get; set; }

        public virtual ICollection<Products> Product { get; set; } 
    }
}
