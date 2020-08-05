using NWEB.Pratice.T05.Core.Model;
using System;
using System.Linq;

namespace NWEB.Pratice.T05.Core
{
    public class DbInitializer
    {
        public static void Seed(FlowerContext context)
        {
            context.Database.EnsureCreated();
            if (context.Categories.Any())
            {
                return;
            }
            var categories = new Category[]
            {
                new Category() {  CategoryName = "Corporate", Description = "Good" },
                    new Category() {  CategoryName = "Love & Romance",  Description = "Good" },
                    new Category() { CategoryName = "Sympathy", Description = "Good" },
                    new Category() { CategoryName = "New Baby", Description = "Good" }
            };
            context.Categories.AddRange(categories);
            var flowers = new Flower[]
            {
                new Flower
                {
                        FlowerName = "Cherry blossom",
                        Description = "Happy Birthday",
                        ImageUrl = "Cherryblossom.jpg",
                        Price = 320m,
                        SalePrice = 50m,
                        StoreDate = DateTime.Now,
                        StoreInventory = 2,
                        Category = categories.Single(c=>c.CategoryName=="Corporate")
                },
                new Flower
                {
                        FlowerName = "Rose",
                        Description = "Love",
                        ImageUrl = "Rose.jpg",
                        Price = 330m,
                        SalePrice = 60m,
                        StoreDate = DateTime.Now,
                        StoreInventory = 5,
                        Category = categories.Single(c=>c.CategoryName=="Love & Romance")
                },
                new Flower
                {
                        FlowerName = "Tuberose",
                        Description = "Happy Birthday",
                        ImageUrl = "Tuberose.jpg",
                        Price = 310m,
                        SalePrice = 40m,
                        StoreDate = DateTime.Now,
                        StoreInventory = 6,
                        Category = categories.Single(c=>c.CategoryName=="Sympathy")
                },
                new Flower
                {
                        FlowerName = "Narcissus",
                        Description = "Happy Birthday",
                        ImageUrl = "Narcissus.jpg",
                        Price = 380m,
                        SalePrice = 50m,
                        StoreDate = DateTime.Now,
                        StoreInventory = 2,
                        Category = categories.Single(c=>c.CategoryName=="New Baby")
                },
                new Flower
                {
                        FlowerName = "Dahlia",
                        Description = "Happy Birthday",
                        ImageUrl = "Dahlia.jpg",
                        Price = 420m,
                        SalePrice = 50m,
                        StoreDate = DateTime.Now,
                        StoreInventory = 2,
                        Category = categories.Single(c=>c.CategoryName=="New Baby")
                }
            };
            context.Flowers.AddRange(flowers);
            context.SaveChanges();
        }
    }
}
