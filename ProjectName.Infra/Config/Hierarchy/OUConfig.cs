using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectName.Infra.Entity.Hierarchy;

namespace ProjectName.Infra.Config.Hierarchy
{
  internal class OUConfig : IEntityTypeConfiguration<OU>
  {
    public void Configure(EntityTypeBuilder<OU> builder)
    {
      string name = typeof(OU).Name; // type.Name
      builder.HasData(
        new OU
        {
          Id = 1,
          Title = name + " 1",
          LEId = 1,
          Description = name + " 1 Description",
        },
         new OU
         {
           Id = 2,
           Title = name + " 2",
           LEId = 2,
           Description = name + " 2 Description",
         }
      );
    }
  }
}