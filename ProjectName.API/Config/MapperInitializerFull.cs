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
      CreateMapAll<OU, OUDto, OUDtoCreate, OUDtoSearch>();
      CreateMapAll<SU, SUDto, SUDtoCreate, SUDtoSearch>();

      CreateMapAll<MadaniBastaSubCategory, 
        MadaniBastaSubCategoryDto, 
        MadaniBastaSubCategoryDtoCreate, 
        MadaniBastaSubCategoryDtoSearch>();

      CreateMapAll<DonationCellMaster,
        DonationCellMasterDto,
        DonationCellMasterDtoCreate,
        DonationCellMasterDtoSearch>();

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
