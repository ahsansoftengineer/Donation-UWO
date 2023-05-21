using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace ProjectName.Infra.Config
{
  public class RoleConfig : IEntityTypeConfiguration<IdentityRole>
  {
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
      builder.HasData(
        new IdentityRole
        {
          Name = "User",
          NormalizedName = "USER",
        },
        new IdentityRole
        {
          Name = "Administrator",
          NormalizedName = "ADMINISTRATOR",
        }
      );
    }
  }
}
