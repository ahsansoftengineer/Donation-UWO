using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjectName.Infra.Entity.MadaniBastaEntity;

namespace ProjectName.Infra.Config.MadaniBastaConfiguration
{
  internal class MadaniBastaConfig : IEntityTypeConfiguration<MadaniBasta>
  {
    public void Configure(EntityTypeBuilder<MadaniBasta> builder)
    {
      builder.HasData(
        new MadaniBasta
        {
          Id = 1,
          Title = "Madani Basta 1",
          Description = "Madani Basta 1 Description",
        },
         new MadaniBasta
         {
           Id = 2,
           Title = "Madani Basta 2",
           Description = "Madani Basta 2 Description",
         }
      );
    }
  }
}
