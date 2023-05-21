using Microsoft.EntityFrameworkCore;
using ProjectName.Infra.Config.Common;
using ProjectName.Infra.Config.Hierarchy;
using ProjectName.Infra.Config.MadaniBastaz;
using ProjectName.Infra.Entity.Hierarchy;
using ProjectName.Infra.Entity.MadaniBastaEntity;

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
      builder.ApplyConfiguration(new CommonConfigz<MadaniBasta>());
      builder.ApplyConfiguration(new MadaniBastaSubCategoryConfig());
      builder.ApplyConfiguration(new CommonConfigz<MadaniBastaEvent>());
      builder.ApplyConfiguration(new CommonConfigz<MadaniBastaPlace>());

      return builder;
    }
  }
}
