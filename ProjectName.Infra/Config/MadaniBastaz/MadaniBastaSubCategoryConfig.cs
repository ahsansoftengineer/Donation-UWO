using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjectName.Infra.Entity.MadaniBastaEntity;

namespace ProjectName.Infra.Config.MadaniBastaz
{
  internal class MadaniBastaSubCategoryConfig : IEntityTypeConfiguration<MadaniBastaSubCategory>
  {
    public void Configure(EntityTypeBuilder<MadaniBastaSubCategory> builder)
    {
      builder.HasData(
        new MadaniBastaSubCategory
        {
          Id = 1,
          Title = "Madani Basta Sub Category 1",
          Description = "Madani Basta Sub Category 1 Description",
          MadaniBastaId = 1,
        },
         new MadaniBastaSubCategory
         {
           Id = 2,
           Title = "Madani Basta Sub Category 2",
           Description = "Madani Basta Sub Category 2 Description",
           MadaniBastaId = 2,
         }
      );
    }
  }
}
