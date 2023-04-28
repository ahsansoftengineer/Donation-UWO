using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectName.Infra.Entity.Hierarchy;

namespace ProjectName.Infra.Config.Hierarchy
{
  internal class LEConfig : IEntityTypeConfiguration<LE>
  {
    public void Configure(EntityTypeBuilder<LE> builder)
    {
      builder.HasData(
        new LE
        {
          Id = 1,
          Title = "LE 1",
          BGId = 1,
          Description = "LE 1 Description",
        },
         new LE
         {
           Id = 2,
           Title = "LE 2",
           BGId = 2,
           Description = "LE 2 Description",
         }
      );
    }
  }
}