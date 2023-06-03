using Microsoft.EntityFrameworkCore;
using ProjectName.Infra.Config.Common;
using ProjectName.Infra.Config.Donationz;
using ProjectName.Infra.Config.Donorz;
using ProjectName.Infra.Config.Hierarchy;
using ProjectName.Infra.Config.MadaniBastaz;
using ProjectName.Infra.Config.Regionz;
using ProjectName.Infra.Entity.Donationz;
using ProjectName.Infra.Entity.Donor;
using ProjectName.Infra.Entity.Extraz;
using ProjectName.Infra.Entity.Hierarchy;
using ProjectName.Infra.Entity.MadaniBastaEntity;
using ProjectName.Infra.Entity.Regionz;

namespace ProjectName.Infra.Config
{
  public static class DI
  {
    public static ModelBuilder AddInitialEntityData(this ModelBuilder builder)
    {
      builder.ApplyConfiguration(new RoleConfig());
      builder.ApplyConfiguration(new CommonConfigz<Org>());
      builder.ApplyConfiguration(new SystemzConfig());
      builder.ApplyConfiguration(new CommonConfigz<BG>());
      builder.ApplyConfiguration(new LEConfig());
      builder.ApplyConfiguration(new OUConfig());
      builder.ApplyConfiguration(new SUConfig());

      builder.ApplyConfiguration(new CommonConfigz<Locationz>());
      builder.ApplyConfiguration(new CommonConfigz<Majlis>());
      builder.ApplyConfiguration(new CommonConfigz<COA>());
      builder.ApplyConfiguration(new CommonConfigz<SysmanAccount>());
      builder.ApplyConfiguration(new CommonConfigz<Branch>());


      builder.ApplyConfiguration(new CommonConfigz<Country>());
      builder.ApplyConfiguration(new StateConfig());
      builder.ApplyConfiguration(new CityConfig());

      builder.ApplyConfiguration(new CommonConfigz<MadaniBasta>());
      builder.ApplyConfiguration(new CommonConfigz<MadaniBastaEvent>());
      builder.ApplyConfiguration(new CommonConfigz<MadaniBastaPlace>());
      builder.ApplyConfiguration(new MadaniBastaSubCategoryConfig());

      builder.ApplyConfiguration(new CommonConfigz<DonationCategory>()); 
      builder.ApplyConfiguration(new DonationTypeConfig());
      builder.ApplyConfiguration(new DonationSubTypeConfig());
      builder.ApplyConfiguration(new DonationCellMasterConfig());
      builder.ApplyConfiguration(new TargetAssignmentConfig());

      builder.ApplyConfiguration(new CommonStatusConfigz<DonorType>());
      builder.ApplyConfiguration(new DonorBasicConfig());
      builder.ApplyConfiguration(new DonorGSBConfig());
      return builder;
    }
  }
}
