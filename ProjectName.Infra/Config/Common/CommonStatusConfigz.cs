using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjectName.Infra.Entity.Base;
using ProjectName.Domain.Enums;

namespace ProjectName.Infra.Config.Common
{
  public class CommonStatusConfigz<T> : IEntityTypeConfiguration<T>
    where T : BaseStatusEntity, new()
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
          Status = Status.None,
        },
         new T
         {
           Id = 2,
           Title = className + " 2 Title",
           Description = className + " 2 Description",
           Status = Status.Activate,
         },
         new T
         {
           Id = 3,
           Title = className + " 3 Title",
           Description = className + " 3 Description",
           Status = Status.DeActivate,
         }
      );
    }
  }
}
