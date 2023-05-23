
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectName.Infra.Entity.Donationz;

namespace ProjectName.Infra.Config.Donationz
{
  internal class DonationSubTypeConfig : IEntityTypeConfiguration<DonationSubType>
  {
    public void Configure(EntityTypeBuilder<DonationSubType> builder)
    {
      string name = typeof(DonationCellMaster).Name; // type.Name
      builder.HasData(
        new DonationSubType
        {
          Id = 1,
          Title = name + " 1",
          Description = name + " 1 Description",
          //DonationCategoryId = 1,
          DonationTypeId = 1,
        },
         new DonationSubType
         {
           Id = 2,
           Title = name + " 2",
           Description = name + " 2 Description",
           //DonationCategoryId = 2,
           DonationTypeId = 2,
         }
      );
    }
  }
}
