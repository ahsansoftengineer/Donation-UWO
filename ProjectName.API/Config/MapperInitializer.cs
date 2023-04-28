﻿using AutoMapper;
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

      CreateMap<Org, OrgDTO>().ReverseMap();
      CreateMap<Org, BaseDTOCreate>().ReverseMap();
      CreateMap<Org, BaseDTORelation>();
      CreateMap<Systemz, SystemzDTO>().ReverseMap();
      CreateMap<Systemz, SystemzDTOCreate>().ReverseMap();
      CreateMap<BG, BGDTO>().ReverseMap();
      CreateMap<BG, BGDTOCreate>().ReverseMap();
      CreateMap<LE, LEDTO>().ReverseMap();
      CreateMap<LE, LEDTOCreate>().ReverseMap();

    }
  }
}
