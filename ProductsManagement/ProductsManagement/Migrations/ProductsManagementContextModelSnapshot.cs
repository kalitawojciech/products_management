﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductsManagement.Models;

namespace ProductsManagement.Migrations
{
    [DbContext(typeof(ProductsManagementContext))]
    partial class ProductsManagementContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProductsManagement.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category_Name");

                    b.HasKey("ID");

                    b.ToTable("Category");

                    b.HasData(
                        new { ID = 1, Category_Name = "Book" },
                        new { ID = 2, Category_Name = "Sport" },
                        new { ID = 3, Category_Name = "Games" },
                        new { ID = 4, Category_Name = "Food" }
                    );
                });

            modelBuilder.Entity("ProductsManagement.Models.Products", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryID");

                    b.Property<string>("Product_Description")
                        .IsRequired()
                        .HasMaxLength(120);

                    b.Property<string>("Product_Name")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<double>("Products_Price");

                    b.Property<int>("category_ID");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new { ID = 1, Product_Description = "This ball is perfect to play football", Product_Name = "Ball", Products_Price = 11.5, category_ID = 2 },
                        new { ID = 2, Product_Description = "You play as a Gerald from Rivia, the best monster killer.", Product_Name = "The Witcher 3: wild hund", Products_Price = 110.0, category_ID = 3 },
                        new { ID = 3, Product_Description = "Tradicional italian pizza made from the best ingridiens", Product_Name = "Pizza", Products_Price = 25.99, category_ID = 4 }
                    );
                });

            modelBuilder.Entity("ProductsManagement.Models.Products", b =>
                {
                    b.HasOne("ProductsManagement.Models.Category", "Category")
                        .WithMany("Product")
                        .HasForeignKey("CategoryID");
                });
#pragma warning restore 612, 618
        }
    }
}
