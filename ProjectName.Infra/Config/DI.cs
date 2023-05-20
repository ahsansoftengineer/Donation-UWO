﻿using Microsoft.EntityFrameworkCore;
using ProjectName.Infra.Config.Hierarchy;
using ProjectName.Infra.Config.MadaniBastaConfiguration;
using ProjectName.Infra.Configuration;

namespace ProjectName.Infra.Config
{
  public static class DI
  {
    public static ModelBuilder AddInitialEntityData(this ModelBuilder builder)
    {
      builder.ApplyConfiguration(new RoleConfig());
      builder.ApplyConfiguration(new OrgConfig());
      builder.ApplyConfiguration(new SystemzConfig());
      builder.ApplyConfiguration(new BGConfig());
      builder.ApplyConfiguration(new LEConfig());
      builder.ApplyConfiguration(new OUConfig());
      builder.ApplyConfiguration(new SUConfig());
      builder.ApplyConfiguration(new MadaniBastaConfig());
      builder.ApplyConfiguration(new MadaniBastaSubCategoryConfig());
      builder.ApplyConfiguration(new MadaniBastaEventConfig());
      builder.ApplyConfiguration(new MadaniBastaPlaceConfig());

      return builder;

    }
  }
}