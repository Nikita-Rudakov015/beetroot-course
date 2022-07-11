using System;
using System.Threading.Tasks;
using Lesson29.EF.DataAccess;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Lesson29.EF.DataAccess.Entities;

namespace Lesson29.EF
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            var context = new ShopDataContext();
            var count = context.Categories.Count();

            var categories = await context.Categories.Include(x => x.Products).ToListAsync();


            foreach (var category in categories)
            {
                Console.WriteLine($"Products in category {category.Title}");
                foreach (var product in category.Products)
                {
                    Console.WriteLine($"\t{product.Title}, price {product.Price}");
                }
            }

            await context.Categories.AddAsync(new DataAccess.Entities.Category
            {
                Title = "Gaming",
                Products = new List<Product>
                {
                    new Product { Title = "PS5", Price = 1000},
                    new Product { Title = "xBox", Price = 100}
                }
            });

            await context.SaveChangesAsync();
        }
    }
}
