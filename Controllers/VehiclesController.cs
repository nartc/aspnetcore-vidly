using System;
using System.Threading.Tasks;
using aspnetcore_vidly.Controllers.Resources;
using aspnetcore_vidly.Models;
using aspnetcore_vidly.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore_vidly.Controllers
{
  [Route("/api/vehicles")]
  public class VehiclesController : Controller
  {
    private readonly IMapper map;
    private readonly AppDbContext context;
    public VehiclesController(IMapper map, AppDbContext context)
    {
      this.context = context;
      this.map = map;

    }

    [HttpPost]
    public async Task<IActionResult> CreateVehicle([FromBody] VehicleResource vehicleResource)
    {
      if (!ModelState.IsValid) 
      {
        return BadRequest(ModelState);
      }
      var vehicle = Mapper.Map<VehicleResource, Vehicle>(vehicleResource);
      vehicle.LastUpdate = DateTime.Now;
      context.Vehicles.Add(vehicle);
      await context.SaveChangesAsync();
      var result = map.Map<Vehicle, VehicleResource>(vehicle);

      return Ok(result);
    }
  }
}