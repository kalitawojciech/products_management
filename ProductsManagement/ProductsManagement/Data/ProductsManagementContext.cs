using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProductsManagement.Models
{
    public class ProductsManagementContext : DbContext
    {
        public ProductsManagementContext (DbContextOptions<ProductsManagementContext> options)
            : base(options)
        {
        }

        public DbSet<ProductsManagement.Models.Products> Products { get; set; }
        public DbSet<ProductsManagement.Models.Category> Categories { get; set; }
    }
}
