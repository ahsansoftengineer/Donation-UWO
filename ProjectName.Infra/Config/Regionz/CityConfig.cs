using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectName.Infra.Entity.Hierarchy;
using ProjectName.Infra.Entity.Regionz;

namespace ProjectName.Infra.Config.Regionz
{
  internal class CityConfig : IEntityTypeConfiguration<City>
  {
    public void Configure(EntityTypeBuilder<City> builder)
    {
      string name = typeof(City).Name; // type.Name
      builder.HasData(
        new City
        {
          Id = 1,
          Title = name + " 1",
          StateId = 1,
          Description = name + " 1 Description",
        },
         new City
         {
           Id = 2,
           Title = name + " 2",
           StateId = 2,
           Description = name + " 2 Description",
         }
      );
    }
  }
}