using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectName.Infra.Entity.Hierarchy;
using ProjectName.Infra.Entity.Regionz;

namespace ProjectName.Infra.Config.Regionz
{
  internal class StateConfig : IEntityTypeConfiguration<State>
  {
    public void Configure(EntityTypeBuilder<State> builder)
    {
      string name = typeof(SU).Name; // type.Name
      builder.HasData(
        new State
        {
          Id = 1,
          Title = name + " 1",
          CountryId = 1,
          Description = name + " 1 Description",
        },
         new State
         {
           Id = 2,
           Title = name + " 2",
           CountryId = 2,
           Description = name + " 2 Description",
         }
      );
    }
  }
}