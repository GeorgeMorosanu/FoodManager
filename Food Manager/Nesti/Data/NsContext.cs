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
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeekMeal>()
                .HasKey(wm => new { wm.WeekId, wm.MealId, wm.Day });
            modelBuilder.Entity<WeekMeal>()
                .HasOne(wm => wm.Week)
                .WithMany(w => w.WeekMeals)
                .HasForeignKey(wm => wm.WeekId);
            modelBuilder.Entity<WeekMeal>()
                .HasOne(wm => wm.Meal)
                .WithMany(m => m.WeekMeals)
                .HasForeignKey(wm => wm.MealId);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<GenericProduct> GenericProducts { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Week> Weeks { get; set; }
        public DbSet<Measurement> Measurements { get; set; }
        public DbSet<WeekMeal> WeekMeals { get; set; }

         
    }
}
