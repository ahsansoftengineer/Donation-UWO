using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectName.Infra.Entity.Hierarchy;

namespace ProjectName.Infra.Config.Hierarchy
{
  internal class OrgConfig : IEntityTypeConfiguration<Org>
  {
    public void Configure(EntityTypeBuilder<Org> builder)
    {
      builder.HasData(
        new Org
        {
          Id = 1,
          Title = "Org 1",
          Description = "Org 1 Description",
        },
         new Org
         {
           Id = 2,
           Title = "Org 2",
           Description = "Org 2 Description",
         }
      );
    }
  }
}