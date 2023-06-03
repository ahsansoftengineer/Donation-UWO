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
      string name = typeof(DonationCellMaster).Name; // type.Name
      builder.HasData(
        new DonationCellMaster
        {
          Id = 1,
          Title = name + " 1",
          Description = name + " 1 Description",
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
           Title = name + " 2",
           Description = name + " 2 Description",
           Address = "",
           LocationzId = 2,
           MajlisId = 2,
           SUId = 2

         }
      );
    }
  }
}
