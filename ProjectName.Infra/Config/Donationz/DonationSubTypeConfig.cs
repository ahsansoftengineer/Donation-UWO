
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectName.Infra.Entity.Donationz;

namespace ProjectName.Infra.Config.Donationz
{
  internal class DonationSubTypeConfig : IEntityTypeConfiguration<DonationSubType>
  {
    public void Configure(EntityTypeBuilder<DonationSubType> builder)
    {
      builder.HasData(
        new DonationSubType
        {
          Id = 1,
          Title = "DonationSubType 1",
          Description = "DonationSubType 1 Description",
          DonationCategoryId = 1,
          DonationTypeId = 1,
        },
         new DonationSubType
         {
           Id = 2,
           Title = "DonationSubType 2",
           Description = "DonationSubType 2 Description",
           DonationCategoryId = 2,
           DonationTypeId = 2,
         }
      );
    }
  }
}
