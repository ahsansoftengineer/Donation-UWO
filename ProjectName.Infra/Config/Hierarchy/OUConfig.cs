using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectName.Infra.Entity.Hierarchy;

namespace ProjectName.Infra.Config.Hierarchy
{
  internal class OUConfig : IEntityTypeConfiguration<OU>
  {
    public void Configure(EntityTypeBuilder<OU> builder)
    {
      builder.HasData(
        new OU
        {
          Id = 1,
          Title = "OU 1",
          LEId = 1,
          Description = "OU 1 Description",
        },
         new OU
         {
           Id = 2,
           Title = "OU 2",
           LEId = 2,
           Description = "OU 2 Description",
         }
      );
    }
  }
}