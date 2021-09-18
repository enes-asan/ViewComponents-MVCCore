using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponents.Entites;

namespace ViewComponents.Models
{
    public class NorthwindDbContext:DbContext
    {
        public NorthwindDbContext(DbContextOptions<NorthwindDbContext> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
