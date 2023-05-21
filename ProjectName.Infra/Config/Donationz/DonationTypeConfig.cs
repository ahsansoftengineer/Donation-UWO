
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjectName.Infra.Entity.Donationz;

namespace ProjectName.Infra.Config.Donationz
{
  internal class DonationTypeConfig : IEntityTypeConfiguration<DonationType>
  {
    public void Configure(EntityTypeBuilder<DonationType> builder)
    {
      builder.HasData(
        new DonationType
        {
          Id = 1,
          Title = "DonationType 1",
          Description = "DonationType 1 Description",
          DonationCategoryId = 1,
          SysmanAccountId = 1,
          COAId= 1,
        },
         new DonationType
         {
           Id = 2,
           Title = "DonationType 2",
           Description = "DonationType 2 Description",
           DonationCategoryId = 2,
           SysmanAccountId = 2,
           COAId = 2,
         }
      );
    }
  }
}

    //public int SysmanAccountId { get; set; }