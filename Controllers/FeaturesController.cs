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
  public class FeaturesController : Controller
  {
    private readonly AppDbContext context;
    private readonly IMapper map;
    public FeaturesController(AppDbContext context, IMapper map)
    {
      this.map = map;
      this.context = context;

    }

    [HttpGet("/api/features")]
    public async Task<IEnumerable<FeatureResource>> GetFeatures()
    {
        var features = await context.Features.ToListAsync();
        return map.Map<List<Feature>, List<FeatureResource>>(features);
    }
  }
}