using ProjectName.Domain.DTOs.Donation;
using ProjectName.Domain.DTOs.MadaniBastaDTOz;
using ProjectName.Domain.Model.Hierarchy;
using ProjectName.Infra.Entity.Donationz;
using ProjectName.Infra.Entity.Hierarchy;
using ProjectName.Infra.Entity.MadaniBastaEntity;

namespace ProjectName.API.Config
{
  public class MapperInitializer : MapperInitializerCommon
  {
    public MapperInitializer(): base()
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
    }
  }

}
