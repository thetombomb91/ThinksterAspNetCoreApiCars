using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThinksterAspNetCoreApiCars.DatabaseEntities;

namespace ThinksterAspNetCoreApiCars
{
    public class CarDatabaseContext : DbContext
    {
        public CarDatabaseContext(DbContextOptions<CarDatabaseContext> options)
          : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(new Car
            {
                Id = "1",
                Name = "Forrester",
            });
        }
        public DbSet<Car> Cars { get; set; }

        public DbSet<Manufacturer> Manufacturers { get; set; }
    }
}
