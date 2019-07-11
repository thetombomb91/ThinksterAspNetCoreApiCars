using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThinksterAspNetCoreApiCars.Repository;

// Below is the skeleton code for a CarsController. 
// For this exercise you will utilize the 
// GetAllCarsAsync() method from the CarRepository to
// return a collection of all the cars inside of our 
// in memory database that has already been created.
//
// Expectations:
//  - Setup the Route for the controller
//  - Use dependency injection to get access to the repository
//  - Make the GET call asynchronous 
//  - Be able to send succesful or non success status codes
//  - Verify inside of Postman that the car collection is retrieved with correct status code
//
//  Notes: You may need to bring in additional using statements to access the different required namespaces

namespace ThinksterAspNetCoreApiCars.Controllers
{
    [ApiController]
    public class CarsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return null;
        }
    }
}
