using Microsoft.EntityFrameworkCore;
using ProductsManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsManagement.Data
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { ID = 1, Category_Name = "Book" },
                new Category { ID = 2, Category_Name = "Sport" },
                new Category { ID = 3, Category_Name = "Games" },
                new Category { ID = 4, Category_Name = "Food" }
                );
            modelBuilder.Entity<Products>().HasData(
                new Products { ID = 1, Product_Name = "Ball", Product_Description = "This ball is perfect to play football", category_ID = 2, Products_Price = 11.5 },
                new Products { ID = 2, Product_Name = "The Witcher 3: wild hund", Product_Description = "You play as a Gerald from Rivia, the best monster killer.", category_ID = 3, Products_Price = 110 },
                new Products { ID = 3, Product_Name = "Pizza", Product_Description = "Traditional italian pizza made from the best ingredients", category_ID = 4, Products_Price = 25.99 }
                );
        }
        
    }
}
