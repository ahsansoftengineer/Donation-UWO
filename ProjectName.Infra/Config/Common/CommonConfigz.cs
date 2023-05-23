using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjectName.Infra.Entity.Base;

namespace ProjectName.Infra.Config.Common
{
  public class CommonConfigz<T> : IEntityTypeConfiguration<T>
    where T : BaseEntity, new()
  {
    public void Configure(EntityTypeBuilder<T> builder)
    {
      string className = typeof(T).Name;
      builder.HasData(
        new T
        {
          Id = 1,
          Title = className + " 1 Title",
          Description = className + " 1 Description",
        },
         new T
         {
           Id = 2,
           Title = className + " 2 Title",
           Description = className + " 2 Description",
         },
         new T
         {
           Id = 3,
           Title = className + " 3 Title",
           Description = className + " 3 Description",
         }
      );
    }
  }
}
