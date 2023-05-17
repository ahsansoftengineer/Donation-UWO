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
      CreateMap(typeof(PagedList<>), typeof(PagedList<>));

      CreateMap<BaseDtoCreate, Org>().ReverseMap();
      CreateMap<Org, OrgDto>();
      CreateMap<Org, BaseDtoRelation>().ReverseMap();
      CreateMap<Org, OrgDtoWithSystemzs>();
      CreateMap<Org, OrgDtoSearch>();
      CreateMapPagedList<Org, OrgDto>();

      CreateMap<Systemz, SystemzDtoCreate>().ReverseMap();
      CreateMap<Systemz, SystemzDto>();
      CreateMap<Systemz, BaseDtoRelation>();
      CreateMap<Systemz, SystemzDtoSearch>();
      CreateMapPagedList<Systemz, SystemzDto>();

      CreateMap<BG, BGDto>().ReverseMap();
      CreateMap<BG, BGDtoCreate>().ReverseMap();
      CreateMap<LE, LEDto>().ReverseMap();
      CreateMap<LE, LEDtoCreate>().ReverseMap();
      CreateMap<OU, OUDto>().ReverseMap();
      CreateMap<OU, OUDtoCreate>().ReverseMap();
      CreateMap<SU, SUDto>().ReverseMap();
      CreateMap<SU, SUDtoCreate>().ReverseMap();

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
