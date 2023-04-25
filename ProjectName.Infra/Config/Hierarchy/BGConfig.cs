using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectName.Infra.Entity.Hierarchy;

namespace ProjectName.Infra.Config.Hierarchy
{
  internal class BGConfig : IEntityTypeConfiguration<BG>
  {
    public void Configure(EntityTypeBuilder<BG> builder)
    {
      builder.HasData(
        new BG
        {
          Id = 1,
          Title = "BG 1",
          Description = "BG 1 Description",
        },
         new BG
         {
           Id = 2,
           Title = "BG 2",
           Description = "BG 2 Description",
         }
      );
    }
  }
}