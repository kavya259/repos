using FoodPointEntities;
using Microsoft.EntityFrameworkCore;
using System;

namespace FoodPointDataAccessLayer
    {
    public class FoodDBContext:DbContext
        {
        public FoodDBContext()
            {
            }
        public FoodDBContext(DbContextOptions<FoodDBContext> options) : base(options)
            {
            }
        public DbSet<FoodItem> FoodItems
            {
            get; set;
            }
        public DbSet<Customer> Customers
            {
            get; set;
            }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-TEJJIDI;Initial Catalog=FoodPointDB;Integrated Security=True");
            }
        protected override void OnModelCreating(ModelBuilder builder)
            {
            base.OnModelCreating(builder);
            }

        }
    }
