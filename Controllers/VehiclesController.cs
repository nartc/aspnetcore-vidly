using aspnetcore_vidly.Controllers.Resources;
using aspnetcore_vidly.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore_vidly.Controllers
{
  [Route("/api/vehicles")]
  public class VehiclesController : Controller
  {
    private readonly IMapper map;
    public VehiclesController(IMapper map)
    {
      this.map = map;

    }

    [HttpPost]
    public IActionResult CreateVehicle([FromBody] VehicleResource vehicleResource)
    {
        var vehicle = Mapper.Map<VehicleResource, Vehicle>(vehicleResource);
        return Ok(vehicle);
    }
  }
}