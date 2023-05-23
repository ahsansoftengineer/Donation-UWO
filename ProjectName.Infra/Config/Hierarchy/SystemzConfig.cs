using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectName.Infra.Entity.Hierarchy;

namespace ProjectName.Infra.Config.Hierarchy
{
  internal class SystemzConfig : IEntityTypeConfiguration<Systemz>
  {
    public void Configure(EntityTypeBuilder<Systemz> builder)
    {
      string name = typeof(SU).Name; // type.Name
      builder.HasData(
        new Systemz
        {
          Id = 1,
          Title = name + " 1",
          OrgId = 1,
          Description = name + " 1 Description",
        },
         new Systemz
         {
           Id = 2,
           Title = name + " 2",
           OrgId = 2,
           Description = name + " 2 Description",
         }
      );
    }
  }
}