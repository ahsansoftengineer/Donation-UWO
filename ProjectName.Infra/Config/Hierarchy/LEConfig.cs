using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectName.Infra.Entity.Hierarchy;

namespace ProjectName.Infra.Config.Hierarchy
{
  internal class LEConfig : IEntityTypeConfiguration<LE>
  {
    public void Configure(EntityTypeBuilder<LE> builder)
    {
      string name = typeof(LE).Name; // type.Name
      builder.HasData(
        new LE
        {
          Id = 1,
          Title = name + " 1",
          BGId = 1,
          Description = name + " 1 Description",
        },
         new LE
         {
           Id = 2,
           Title = name + " 2",
           BGId = 2,
           Description = name + " 2 Description",
         }
      );
    }
  }
}