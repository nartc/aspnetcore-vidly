using System.Linq;
using aspnetcore_vidly.Controllers.Resources;
using aspnetcore_vidly.Models;
using AutoMapper;

namespace aspnetcore_vidly.Mapping {
    public class MappingProfile: Profile {
        public MappingProfile() {
            // Domain to API Resource
            CreateMap < Make, MakeResource > ();
            CreateMap < Model, ModelResource > ();
            CreateMap < Feature, FeatureResource > ();

            // API Resource to Domain
            CreateMap < VehicleResource, Vehicle > ()
                .ForMember(
                    vehicle => vehicle.ContactName,
                    operation => operation
                    .MapFrom(
                        vehicleResource => vehicleResource.Contact.Name))
                .ForMember(
                    vehicle => vehicle.ContactEmail,
                    operation => operation
                    .MapFrom(
                        vehicleResource => vehicleResource.Contact.Email))
                .ForMember(
                    vehicle => vehicle.ContactPhone,
                    operation => operation
                    .MapFrom(
                        vehicleResource => vehicleResource.Contact.Phone))
                .ForMember(
                    vehicle => vehicle.Features,
                    operation => operation
                    .MapFrom(
                        vehicleResource => vehicleResource.Features.Select(
                            id => new VehicleFeature {FeatureId = id})));
        }
    }
}