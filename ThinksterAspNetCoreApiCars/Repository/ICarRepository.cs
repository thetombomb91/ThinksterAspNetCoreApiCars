using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThinksterAspNetCoreApiCars.DatabaseEntities;

namespace ThinksterAspNetCoreApiCars.Repository
{
    public interface ICarRepository
    {
        Task<List<Car>> GetAllCarsAsync();
    }
}
