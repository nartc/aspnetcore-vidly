using System.Collections.Generic;
using System.Threading.Tasks;
using aspnetcore_vidly.Controllers.Resources;
using aspnetcore_vidly.Models;
using aspnetcore_vidly.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace aspnetcore_vidly.Controllers
{

  public class MakesController : Controller
  {
    private readonly AppDbContext context;
    private readonly IMapper map;
    public MakesController(AppDbContext context, IMapper map)
    {
      this.map = map;
      this.context = context;
    }

    [HttpGet("/api/makes")]
    public async Task<IEnumerable<MakeResource>> GetMakes()
    {
      var makes = await context.Makes.Include(m => m.Models).ToListAsync();
      return map.Map<List<Make>, List<MakeResource>>(makes);
    }
  }
}