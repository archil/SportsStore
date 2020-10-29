using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Domain.Db
{
    public class SportsStoreDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
