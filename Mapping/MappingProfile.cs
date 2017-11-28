using aspnetcore_vidly.Controllers.Resources;
using aspnetcore_vidly.Models;
using AutoMapper;

namespace aspnetcore_vidly.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResource>();
        }
    }
}