using AutoMapper;
using ProjectName.Domain.Model.Base;
using ProjectName.Domain.Model.Hierarchy;
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

      CreateMap<Org, OrgDto>().ReverseMap();
      CreateMap<Org, BaseDtoCreate>().ReverseMap();
      CreateMap<Org, BaseDtoRelation>();
      CreateMap<Systemz, SystemzDto>().ReverseMap();
      CreateMap<Systemz, SystemzDtoCreate>().ReverseMap();
      CreateMap<BG, BGDto>().ReverseMap();
      CreateMap<BG, BGDtoCreate>().ReverseMap();
      CreateMap<LE, LEDto>().ReverseMap();
      CreateMap<LE, LEDtoCreate>().ReverseMap();
      CreateMap<OU, OUDto>().ReverseMap();
      CreateMap<OU, OUDtoCreate>().ReverseMap();

    }
  }
}
