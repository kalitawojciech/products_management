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
        [Display(Name ="Product's Name")]
        [StringLength(60, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""-]*$", ErrorMessage = "Product's name must consist letters, numbers, $*-+")]
        [Required]
        public string Product_Name { get; set; }

        [Display(Name = "Product's Description")]
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""-]*$", ErrorMessage = "Product's dascription must consist letters, numbers, $*-+")]
        [StringLength(120, MinimumLength = 3)]
        public string Product_Description { get; set; }

        [Display(Name = "Product's Category")]
        [Required]
        public int category_ID { get; set; }

        [Display(Name = "Product's Price")]
        [DataType(DataType.Currency)]
        public double Products_Price { get; set; }

        public virtual Category Category { get; set; }
    }
}
