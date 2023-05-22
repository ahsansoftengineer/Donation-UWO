using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjectName.Infra.Entity.Hierarchy;
using ProjectName.Infra.Entity.Donationz;

namespace ProjectName.Infra.Config.Donationz
{
  internal class DonationCellMasterConfig : IEntityTypeConfiguration<DonationCellMaster>
  {
    public void Configure(EntityTypeBuilder<DonationCellMaster> builder)
    {
      builder.HasData(
        new DonationCellMaster
        {
          Id = 1,
          Title = "DonationCellMaster 1",
          Description = "DonationCellMaster 1 Description",
          Address = "",
          LocationzId = 1,
          MajlisId = 1,
          //BGId = 1,
          //LEId = 1,
          //OUId = 1,
          SUId = 1

        },
         new DonationCellMaster
         {
           Id = 2,
           Title = "DonationCellMaster 2",
           Description = "DonationCellMaster 2 Description",
           Address = "",
           LocationzId = 2,
           MajlisId = 2,
           //BGId = 2,
           //LEId = 2,
           //OUId = 2,
           SUId = 2

         }
      );
    }
  }
}
