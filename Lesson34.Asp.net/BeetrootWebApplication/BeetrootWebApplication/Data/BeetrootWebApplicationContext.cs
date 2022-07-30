using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BeetrootWebApplication.Models;

namespace BeetrootWebApplication.Data
{
    public class BeetrootWebApplicationContext : DbContext
    {
        public BeetrootWebApplicationContext (DbContextOptions<BeetrootWebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<BeetrootWebApplication.Models.ProductModel> ProductModel { get; set; }
    }
}
