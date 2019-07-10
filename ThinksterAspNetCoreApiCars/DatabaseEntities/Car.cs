using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThinksterAspNetCoreApiCars.DatabaseEntities
{
    public class Car
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}
