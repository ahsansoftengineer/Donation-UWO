using AutoMapper;
using ProjectName.Domain.Base;
using ProjectName.Domain.Model.Hierarchy;
using ProjectName.Infra.Entity.Hierarchy;
using System.Runtime.CompilerServices;
using X.PagedList;

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

      // Future Reference
      //CreateMap<Org, OrgDto>();
      //CreateMapPagedList<Org, OrgDto>();
      //CreateMap<Org, BaseDtoRelation>();
      //CreateMap<Org, OrgDtoWithSystemzs>();
      //CreateMap<Org, OrgDtoSearch>();
      //CreateMap<BaseDtoCreate, Org>(); //.ReverseMap()

      CreateMap(typeof(PagedList<>), typeof(PagedList<>));

      CreateMapAll<Org, OrgDto, BaseDtoCreate, OrgDtoSearch>();
      CreateMap<Org, OrgDtoWithSystemzs>();
      CreateMapAll<Systemz, SystemzDto, SystemzDtoCreate, SystemzDtoSearch>();
      CreateMapAll<BG, BGDto, BGDtoCreate, BGDtoSearch>();
      CreateMapAll<LE, LEDto, LEDtoCreate, LEDtoSearch>();


      CreateMap<OU, OUDto>().ReverseMap();
      CreateMap<OU, OUDtoCreate>().ReverseMap();
      CreateMap<SU, SUDto>().ReverseMap();
      CreateMap<SU, SUDtoCreate>().ReverseMap();

    }
    private void CreateMapAll<Entity, Dto, Create, Search>() // Relation
    {
      CreateMap<Entity, Dto>();
      CreateMapPagedList<Entity, Dto>();
      CreateMap<Entity, BaseDtoRelation>();
      CreateMap<Entity, Search>();
      CreateMap<Create, Entity>();
    }
    private void CreateMapPagedList<Src, Dest>()
    {
      CreateMap<IPagedList<Src>, PaginateResponse<Dest>>()
        .ForMember(d => d.Records, c => c.MapFrom(y => y.ToList()))
        .ForMember(d => d.Count, c => c.MapFrom(s => s.TotalItemCount))
        .ForMember(d => d.PageNo, c => c.MapFrom(s => s.PageNumber))
        .ForMember(d => d.PageSize, c => c.MapFrom(s => s.PageSize));
    }
  }

}
