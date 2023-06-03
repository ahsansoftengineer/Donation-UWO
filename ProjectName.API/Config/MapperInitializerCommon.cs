using ProjectName.Infra.Entity.Donationz;
using ProjectName.Infra.Entity.Donor;
using ProjectName.Infra.Entity.Extraz;
using ProjectName.Infra.Entity.Hierarchy;
using ProjectName.Infra.Entity.MadaniBastaEntity;
using ProjectName.Infra.Entity.Regionz;

namespace ProjectName.API.Config
{
  public class MapperInitializerCommon : MapperInitializerBase
  {
    public MapperInitializerCommon() : base()
    {
      CreateMapCommon<Org>();
      CreateMapCommon<BG>();
      CreateMapCommon<MadaniBasta>();
      CreateMapCommon<MadaniBastaEvent>();
      CreateMapCommon<MadaniBastaPlace>();
      CreateMapCommon<DonationType>();
      CreateMapCommon<DonationCategory>();
      CreateMapCommon<Locationz>();
      CreateMapCommon<Branch>();
      CreateMapCommon<Majlis>();
      CreateMapCommon<COA>();
      CreateMapCommon<SysmanAccount>();
      CreateMapCommon<Country>();
      CreateMapCommonStatus<DonorType>();

    }
  }
}
