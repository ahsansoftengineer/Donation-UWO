using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjectName.Infra.Entity.MadaniBastaEntity;

namespace ProjectName.Infra.Config.MadaniBastaConfiguration
{
  internal class MadaniBastaEventConfig : IEntityTypeConfiguration<MadaniBastaEvent>
  {
    public void Configure(EntityTypeBuilder<MadaniBastaEvent> builder)
    {
      builder.HasData(
        new MadaniBastaEvent
        {
          Id = 1,
          Title = "Madani Basta Event 1",
          Description = "Madani Basta Event 1 Description",
        },
         new MadaniBastaEvent
         {
           Id = 2,
           Title = "Madani Basta Event 2",
           Description = "Madani Basta Event 2 Description",
         }
      );
    }
  }
}
