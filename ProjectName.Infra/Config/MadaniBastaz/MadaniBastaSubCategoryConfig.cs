using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjectName.Infra.Entity.MadaniBastaEntity;

namespace ProjectName.Infra.Config.MadaniBastaz
{
  internal class MadaniBastaSubCategoryConfig : IEntityTypeConfiguration<MadaniBastaSubCategory>
  {
    public void Configure(EntityTypeBuilder<MadaniBastaSubCategory> builder)
    {
      string name = typeof(MadaniBastaSubCategory).Name; // type.Name
      builder.HasData(
        new MadaniBastaSubCategory
        {
          Id = 1,
          Title = name + " 1",
          Description = name + " 1 Description",
          MadaniBastaId = 1,
        },
         new MadaniBastaSubCategory
         {
           Id = 2,
           Title = name + " 2",
           Description = name + " 2 Description",
           MadaniBastaId = 2,
         }
      );
    }
  }
}
