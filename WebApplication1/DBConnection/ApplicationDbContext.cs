using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.DbConnection
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ProductModel> Products { get; set; }

        private List<ProductModel> GetData(int numberOfTimes)
        {
            var products = new List<ProductModel>();

            for (int i = 1; i <= numberOfTimes; i++)
            {
                Size size;
                int priceValue;
                Category category;

                switch ((i - 1) % 3)
                {
                    case 0:
                        size = Size.Large;
                        priceValue = 100;
                        category = Category.Standard;
                        break;
                    case 1:
                        size = Size.Medium;
                        priceValue = 500;
                        category = Category.Premium;
                        break;
                    case 2:
                        size = Size.Small;
                        priceValue = 275;
                        category = Category.Economy;
                        break;
                    default:
                        size = Size.Large;
                        priceValue = 100;
                        category = Category.Standard;
                        break;
                }

                products.Add(new ProductModel
                {
                    Id = i,
                    ProductName = size.ToString(),
                    ProductSize = size,
                    ProductPrice = (Price)priceValue,
                    MfgDate = DateTime.Now.AddDays(-i),
                    ProductCategory = category
                    // Add other properties here
                });
            }

            return products;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>()
                .Property(e => e.MfgDate)
                .HasColumnType("date");

            var products = GetData(20);

            foreach (var product in products)
            {
                modelBuilder.Entity<ProductModel>().HasData(product);
            }
            modelBuilder.Entity<ProductModel>()
                .Property(e => e.ProductSize)
                .HasConversion<string>();

            modelBuilder.Entity<ProductModel>()
                .Property(e => e.ProductCategory)
                .HasConversion<string>();
        }
    }
}
