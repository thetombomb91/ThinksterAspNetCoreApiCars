using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThinksterAspNetCoreApiCars.DatabaseEntities;

namespace ThinksterAspNetCoreApiCars.Repository
{
    public class CarRepository : ICarRepository
    {
        private readonly CarDatabaseContext _carDbContext;

        public CarRepository(CarDatabaseContext carDatabaseContext)
        {
            _carDbContext = carDatabaseContext;
            _carDbContext.Database.EnsureCreated();
        }
        public Task<List<Car>> GetAllCarsAsync()
        {
            var query = _carDbContext.Cars;
            return query.ToListAsync();
        }
    }
}
