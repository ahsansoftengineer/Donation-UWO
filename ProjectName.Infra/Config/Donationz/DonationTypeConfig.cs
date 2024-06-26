﻿
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjectName.Infra.Entity.Donationz;

namespace ProjectName.Infra.Config.Donationz
{
  internal class DonationTypeConfig : IEntityTypeConfiguration<DonationType>
  {
    public void Configure(EntityTypeBuilder<DonationType> builder)
    {
      string name = typeof(DonationType).Name; // type.Name
      builder.HasData(
        new DonationType
        {
          Id = 1,
          Title = name + " 1",
          Description = name + " 1 Description",
          DonationCategoryId = 1,
          SysmanAccountId = 1,
          COAId= 1,
        },
         new DonationType
         {
           Id = 2,
           Title = name + " 2",
           Description = name + " Description",
           DonationCategoryId = 2,
           SysmanAccountId = 2,
           COAId = 2,
         }
      );
    }
  }
}

    //public int SysmanAccountId { get; set; }