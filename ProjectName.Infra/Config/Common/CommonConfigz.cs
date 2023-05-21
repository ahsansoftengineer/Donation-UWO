using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjectName.Infra.Entity.Base;

namespace ProjectName.Infra.Config.Common
{
    public class CommonConfigz<T> : IEntityTypeConfiguration<T>
      where T : BaseEntity
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasData(
              new
              {
                  Id = 1,
                  Title = nameof(T) + " 1 Title",
                  Description = nameof(T) + " 1 Description",
              },
               new
               {
                   Id = 2,
                   Title = nameof(T) + " 2 Title",
                   Description = nameof(T) + " 2 Description",
               },
               new
               {
                   Id = 3,
                   Title = nameof(T) + " 3 Title",
                   Description = nameof(T) + " 3 Description",
               }
            );
        }
    }
}
