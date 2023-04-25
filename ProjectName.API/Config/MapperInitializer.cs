using AutoMapper;
using ProjectName.Domain.Model;
using ProjectName.Domain.Model.Base;
using ProjectName.Infra.Entity;
using ProjectName.Infra.Entity.Hierarchy;

namespace ProjectName.API.Config
{
    public class MapperInitializer : Profile
  {
    public MapperInitializer()
    {
      // DTOs => Domain
      // Entity => Infrastructure
      // Cannot Put in This Class in Domain because Domain cannot be Dependent on Infrastructure
      // API is Depending on both Domain and Infrastructure

      CreateMap<Country, CountryDTO>().ReverseMap();
      CreateMap<Org, BaseDTOCreateFull>().ReverseMap();
      CreateMap<Org, BaseDTOCreate>().ReverseMap();
      //CreateMap<Country, CreateCountryDTO>().ReverseMap();
      //CreateMap<Hotel, HotelDTO>().ReverseMap();
      //CreateMap<Hotel, CreateHotelDTO>().ReverseMap();
      //CreateMap<ApiUser, UserDTO>().ReverseMap();
    }
  }
}
