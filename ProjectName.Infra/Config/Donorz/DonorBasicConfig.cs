using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjectName.Infra.Entity.Donor;
using ProjectName.Domain.Enums;

namespace ProjectName.Infra.Config.Donorz
{
  internal class DonorBasicConfig : IEntityTypeConfiguration<DonorBasic>
  {
    public void Configure(EntityTypeBuilder<DonorBasic> builder)
    {
      string name = typeof(DonorBasic).Name; // type.Name
      builder.HasData(
        new DonorBasic
        {
          Id = 1,
          Title = name + " 1",
          Description = name + " 1 Description",
          Mobile = "3212824400",
          DonorTypeId = 1,
          OrgId = 1,
          CityId = 1,
          Email = name + "44@gmail.com",
          Gender = Gender.Male,
          Address = name + "44 Address"
        },
        new DonorBasic
        {
          Id = 2,
          Title = name + " 2",
          Description = name + " 2 Description",
          Mobile = "3212825500",
          DonorTypeId = 2,
          OrgId = 2,
          CityId = 2,
          Email = name + "55@gmail.com",
          Gender = Gender.Male,
          Address = name + "55 Address"
        },
         new DonorBasic
         {
           Id = 3,
           Title = name + " 3",
           Description = name + " 3 Description",
           Mobile = "3212826600",
           DonorTypeId = 2,
           OrgId = 2,
           CityId = 2,
           Email = name + "66@gmail.com",
           Gender = Gender.Male,
           Address = name + "66 Address"
         }
      );
    }
  }
}
