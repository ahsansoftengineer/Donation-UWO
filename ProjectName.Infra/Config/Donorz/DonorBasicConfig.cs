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
          Mobile = "3212827700",
          Email = "ahsansoftengineer@gmail.com",
          DonorTypeId = 1,
          OrgId = 1,
          CityId = 1,
          Gender = Gender.Male
        },
        new DonorBasic
        {
          Id = 2,
          Title = name + " 2",
          Description = name + " 2 Description",
          Mobile = "3212825500",
          Email = "asdf@gmail.com",
          DonorTypeId = 2,
          OrgId = 2,
          CityId = 2,
          Gender = Gender.None
        },
         new DonorBasic
         {
           Id = 3,
           Title = name + " 3",
           Description = name + " 3 Description",
           Mobile = "3212826600",
           Email = "sumaya@gmail.com",
           DonorTypeId = 2,
           OrgId = 2,
           CityId = 2,
           Gender = Gender.Female
         }
      );
    }
  }
}
