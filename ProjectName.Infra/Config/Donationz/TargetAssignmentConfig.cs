using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ProjectName.Infra.Entity.Donationz;

namespace ProjectName.Infra.Config.Donationz
{
  internal class TargetAssignmentConfig : IEntityTypeConfiguration<TargetAssignment>
  {
    public void Configure(EntityTypeBuilder<TargetAssignment> builder)
    {
      string name = typeof(TargetAssignment).Name; // type.Name
      builder.HasData(
        new TargetAssignment
        {
          Id = 1,
          Title = name + " 1",
          Description = name + " 1 Description",
          TargetFrom = DateTime.UtcNow,
          TargetFor = DateTime.UtcNow.AddMonths(1),
          IncreasePercentage = 20,
          SystemzId = 1,
          MajlisId = 1,
          SUId = 1

        },
         new TargetAssignment
         {
           Id = 2,
           Title = name + " 2",
           Description = name + " 2 Description",
           TargetFrom = DateTime.UtcNow,
           TargetFor = DateTime.UtcNow.AddMonths(1),
           IncreasePercentage = 20,
           SystemzId = 2,
           MajlisId = 2,
           SUId = 2

         }
      );
    }
  }
}
