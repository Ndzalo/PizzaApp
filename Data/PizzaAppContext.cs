using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PizzaApp.Model;

namespace PizzaApp.Data
{
    public class PizzaAppContext : DbContext
    {
        public PizzaAppContext (DbContextOptions<PizzaAppContext> options)
            : base(options)
        {
        }

        public DbSet<PizzaApp.Model.Pizza> Pizza { get; set; } = default!;
    }
}
