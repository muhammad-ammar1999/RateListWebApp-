using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ShopMs.Models;

namespace ShopMs.Data
{
    public class ShopMsContext : DbContext
    {

        public ShopMsContext()
        {

        }

        public ShopMsContext(DbContextOptions<ShopMsContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var Sales = modelBuilder.Entity<Sales>();
            Sales.ToTable("SalesReport");
            Sales.Property(S => S.DName).IsRequired();
        }
        public DbSet<RateList> RateList { get; set; }
        public DbSet<Sales> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var directory = System.IO.Directory.GetCurrentDirectory();

                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(directory)
                    .AddJsonFile("appsettings.json")
                    .Build();

                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            }
        }

    }
}
