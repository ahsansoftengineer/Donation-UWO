using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjectName.Infra.Entity.MadaniBastaEntity;

namespace ProjectName.Infra.Config.MadaniBastaConfiguration
{
  internal class MadaniBastaPlaceConfig : IEntityTypeConfiguration<MadaniBastaPlace>
  {
    public void Configure(EntityTypeBuilder<MadaniBastaPlace> builder)
    {
      builder.HasData(
        new MadaniBastaPlace
        {
          Id = 1,
          Title = "Madani Basta Place 1",
          Description = "Madani Basta Place 1 Description",
        },
         new MadaniBastaPlace
         {
           Id = 2,
           Title = "Madani Basta Place 2",
           Description = "Madani Basta Place 2 Description",
         }
      );
    }
  }
}
