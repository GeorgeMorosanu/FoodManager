using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;


using Nesti.Data.Entities;

namespace Nesti.Data
{
    public class NsContext : DbContext
    {

        public NsContext(DbContextOptions<NsContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies();
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<GenericProduct> GenericProducts { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Week> Weeks { get; set; }
        public DbSet<Measurement> Measurements { get; set; }
    }
}
