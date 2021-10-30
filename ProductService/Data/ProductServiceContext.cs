using Microsoft.EntityFrameworkCore;
using ProductService.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductService.Data
{
    public class ProductServiceContext : DbContext
    {
        public ProductServiceContext(DbContextOptions<ProductServiceContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
