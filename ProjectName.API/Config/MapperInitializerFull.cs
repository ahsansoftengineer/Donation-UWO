using ProjectName.Domain.DTOs.Donation;
using ProjectName.Domain.DTOs.MadaniBastaDTOz;
using ProjectName.Domain.DTOs.Hierarchy;
using ProjectName.Infra.Entity.Donationz;
using ProjectName.Infra.Entity.Hierarchy;
using ProjectName.Infra.Entity.MadaniBastaEntity;
using ProjectName.Infra.Entity.Regionz;
using ProjectName.Domain.DTOs.Regionz;
using ProjectName.Infra.Entity.Donor;
using ProjectName.Domain.DTOs.Donor;

namespace ProjectName.API.Config
{
  public class MapperInitializerFull : MapperInitializerCommon
  {
    public MapperInitializerFull(): base()
    {
      CreateMapAll<Systemz, SystemzDto, SystemzDtoCreate, SystemzDtoSearch>();

      CreateMapAll<LE, LEDto, LEDtoCreate, LEDtoSearch>();
      CreateMap<OUDtoCreate, OUDtoCreateToEntity>();
        //.ForMember(d => d.LogoImg, c => c.MapFrom(y => y.LogoImg.Name))
        //.ForMember(d => d.TopImg, c => c.MapFrom(y => y.TopImg.Name))
        //.ForMember(d => d.WarningImg, c => c.MapFrom(y => y.WarningImg.Name))
        //.ForMember(d => d.FooterImg, c => c.MapFrom(y => y.FooterImg.Name));

      CreateMapAll<OU, OUDto, OUDtoCreateToEntity, OUDtoSearch>();
      CreateMapAll<SU, SUDto, SUDtoCreate, SUDtoSearch>();

      CreateMapAll<MadaniBastaSubCategory, 
        MadaniBastaSubCategoryDto, 
        MadaniBastaSubCategoryDtoCreate, 
        MadaniBastaSubCategoryDtoSearch>();

      CreateMapAll<DonationCellMaster,
        DonationCellMasterDto,
        DonationCellMasterDtoCreate,
        DonationCellMasterDtoSearch>();

      CreateMapAll<DonationType,
        DonationTypeDto,
        DonationTypeDtoCreate,
        DonationTypeDtoSearch>();

      CreateMapAll<DonationSubType,
        DonationSubTypeDto,
        DonationSubTypeDtoCreate,
        DonationSubTypeDtoSearch>();

      CreateMapAll<TargetAssignment,
        TargetAssignmentDto,
        TargetAssignmentDtoCreate,
        TargetAssignmenteDtoSearch>();

      CreateMapAll<State,
        StateDto,
        StateDtoCreate,
        StateDtoSearch>();

      CreateMapAll<City,
        CityDto,
        CityDtoCreate,
        CityDtoSearch>();

      CreateMapAll<DonorBasic,
        DonorBasicDto,
        DonorBasicDtoCreate,
        DonorBasicDtoSearch>();

      CreateMapAll<DonorGSB,
       DonorGSBDto,
       DonorGSBDtoCreate,
       DonorGSBDtoSearch>();
    }
  }

}
