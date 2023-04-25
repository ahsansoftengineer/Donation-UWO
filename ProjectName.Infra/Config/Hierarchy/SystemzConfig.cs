using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectName.Infra.Entity.Hierarchy;

namespace ProjectName.Infra.Config.Hierarchy
{
  internal class SystemzConfig : IEntityTypeConfiguration<Systemz>
  {
    public void Configure(EntityTypeBuilder<Systemz> builder)
    {
      builder.HasData(
        new Systemz
        {
          Id = 1,
          Title = "Systemz 1",
          OrgId = 1,
          Description = "Systemz 1 Description",
        },
         new Systemz
         {
           Id = 2,
           Title = "Systemz 2",
           OrgId = 2,
           Description = "Systemz 2 Description",
         }
      );
    }
  }
}