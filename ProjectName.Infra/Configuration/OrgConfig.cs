using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectName.Infra.Entity.Hierarchy;

namespace ProjectName.Infra.Configuration
{
    internal class OrgConfig : IEntityTypeConfiguration<Org>
  {
    public void Configure(EntityTypeBuilder<Org> builder)
    {
      builder.HasData(
        new Org
        {
          Id = 1,
          Title = "Dawat-e-Islami",
          Description = "No Description",
          CreatedAt = DateTime.UtcNow,
          UpdatedAt = DateTime.UtcNow
        },
         new Org
         {
           Id = 2,
           Title = "Jamia",
           Description = "No Description",
           CreatedAt = DateTime.UtcNow,
           UpdatedAt = DateTime.UtcNow
         }
      );
    }
  }
}