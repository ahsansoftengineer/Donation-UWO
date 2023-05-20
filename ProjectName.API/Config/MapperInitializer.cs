using AutoMapper;
using ProjectName.Domain.Base;
using ProjectName.Domain.DTOs.MadaniBastaDTOz;
using ProjectName.Domain.Model.Hierarchy;
using ProjectName.Infra.Entity.Hierarchy;
using ProjectName.Infra.Entity.MadaniBastaEntity;
using System.Net;
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

      CreateMapAllWithChild<Org, OrgDto, BaseDtoCreate, OrgDtoSearch, OrgDtoWithSystemzs>();
      CreateMapAll<Systemz, SystemzDto, SystemzDtoCreate, SystemzDtoSearch>();
      CreateMapAll<BG, BGDto, BGDtoCreate, BGDtoSearch>();
      CreateMapAll<LE, LEDto, LEDtoCreate, LEDtoSearch>();
      CreateMapAll<OU, OUDto, OUDtoCreate, OUDtoSearch>();
      CreateMapAll<SU, SUDto, SUDtoCreate, SUDtoSearch>();
      CreateMapAll<MadaniBasta, MadaniBastaDto, MadaniBastaDtoCreate, MadaniBastaDtoSearch>();
    }
    private void CreateMapAllWithChild<Entity, Dto, Create, Search, Child>() // Relation
    {
      CreateMapAll<Entity, Dto, Create, Search>();
      CreateMap<Entity, Child>();
    }
    private void CreateMapAll<Entity, Dto, Create, Search>() // Relation
    {
      CreateMap<Entity, Dto>();
      CreateMapPagedList<Entity, Dto>();
      CreateMapSingle<Entity, Dto>();
      CreateMap<Entity, BaseDtoRelation>();
      CreateMap<Entity, Search>();
      CreateMap<Create, Entity>();
    }
    private void CreateMapSingle<Src, Dest>()
    {
      CreateMap<Src, BaseDTOSingle<Dest>>()
        .ForMember(d => d.Record, c => c.MapFrom(y => y))
        .ForMember(d => d.Status, c => c.MapFrom(y => HttpStatusCode.OK));
    }

    private void CreateMapPagedList<Src, Dest>()
    {
      CreateMap<IPagedList<Src>, PaginateResponse<Dest>>()
        .ForMember(d => d.Records, c => c.MapFrom(y => y.ToList()))
        .ForMember(d => d.Count, c => c.MapFrom(s => s.TotalItemCount))
        .ForMember(d => d.PageNo, c => c.MapFrom(s => s.PageNumber))
        .ForMember(d => d.PageSize, c => c.MapFrom(s => s.PageSize))
        .ForMember(d => d.Status, c => c.MapFrom(s => HttpStatusCode.OK));
    }
  }

}
