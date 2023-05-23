using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectName.Infra.Entity.Hierarchy;

namespace ProjectName.Infra.Config.Hierarchy
{
  internal class SUConfig : IEntityTypeConfiguration<SU>
  {
    public void Configure(EntityTypeBuilder<SU> builder)
    {
      string name = typeof(SU).Name; // type.Name
      builder.HasData(
        new SU
        {
          Id = 1,
          Title = name + " 1",
          OUId = 1,
          Description = name + " 1 Description",
        },
         new SU
         {
           Id = 2,
           Title = name + " 2",
           OUId = 2,
           Description = name + " 2 Description",
         }
      );
    }
  }
}