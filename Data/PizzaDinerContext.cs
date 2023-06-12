using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PizzaDiner.Models;

namespace PizzaDiner.Data
{
    public class PizzaDinerContext : DbContext
    {
        public PizzaDinerContext (DbContextOptions<PizzaDinerContext> options)
            : base(options)
        {
        }

        public DbSet<PizzaDiner.Models.Pizza> Pizza { get; set; } = default!;
    }
}
