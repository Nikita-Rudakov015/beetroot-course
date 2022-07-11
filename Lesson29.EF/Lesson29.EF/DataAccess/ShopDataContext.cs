using Lesson29.EF.DataAccess.Entities;
using Lesson29.EF.DataAccess.Mappings;
using Microsoft.EntityFrameworkCore;


namespace Lesson29.EF.DataAccess
{
    public class ShopDataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMapping());
            modelBuilder.ApplyConfiguration(new ProductMapping());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Server=.;Database=ShopDB;Trusted_Connection=True;
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=ShopDB;Trusted_Connection=True;");
        }
    }
}
