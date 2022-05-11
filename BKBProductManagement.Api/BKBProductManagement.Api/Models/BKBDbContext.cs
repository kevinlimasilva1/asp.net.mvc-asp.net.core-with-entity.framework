using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BKBProductManagement.Api.Models
{
    public class BKBDbContext : DbContext
    {
        public BKBDbContext(DbContextOptions<BKBDbContext> options) : base(options)
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
    }
}
