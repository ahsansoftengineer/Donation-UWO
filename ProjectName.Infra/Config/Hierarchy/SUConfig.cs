using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectName.Infra.Entity.Hierarchy;

namespace ProjectName.Infra.Config.Hierarchy
{
  internal class SUConfig : IEntityTypeConfiguration<SU>
  {
    public void Configure(EntityTypeBuilder<SU> builder)
    {
      builder.HasData(
        new SU
        {
          Id = 1,
          Title = "SU 1",
          OUId = 1,
          Description = "SU 1 Description",
        },
         new SU
         {
           Id = 2,
           Title = "SU 2",
           OUId = 2,
           Description = "SU 2 Description",
         }
      );
    }
  }
}