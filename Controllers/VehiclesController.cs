using aspnetcore_vidly.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore_vidly.Controllers
{
    [Route("/api/vehicles")]
    public class VehiclesController : Controller
    {
        [HttpPost]
        public IActionResult CreateVehicle(Vehicle vehicle)
        {
            return Ok(vehicle);
        }
    }
}