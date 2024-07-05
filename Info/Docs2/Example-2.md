### ISimple Repository
```csharp
namespace Donation.Application.Common.Persistence
{
  public interface ISimpleRepo<TEntity>
  {
    void Add(TEntity menu);
  }
}
```
### DB Context 
```csharp
using Donation.Domain.HierarchyAggregate;
using Donation.Domain.Menu;
using Microsoft.EntityFrameworkCore;

namespace Donation.Infrastructure.Persistence
{
  public class DonationDbContext : DbContext
  {
    public DonationDbContext(DbContextOptions<DonationDbContext> options) : base(options) {  }

    public DbSet<Org> Orgs { get; set; } = null!;
    public DbSet<Systemz> Systemzs { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfigurationsFromAssembly(
        typeof(DonationDbContext).Assembly
      );
      base.OnModelCreating(modelBuilder);
    }
  }
}
```
### Simple Repository
```csharp
using Donation.Application.Common.Persistence;
namespace Donation.Infrastructure.Persistence.Repositories
{
  public class SimpleRepo<TEntity> : ISimpleRepo<TEntity>
  {
    protected readonly DonationDbContext dbContext;

    public SimpleRepo(DonationDbContext dbContext)
    {
      this.dbContext = dbContext;
    }
    public void Add(TEntity me)
    {
      dbContext.Add(me);
      dbContext.SaveChanges();
    }
  }
}
```
### Org Repository
- Rest of them exactly the same
```csharp
using Donation.Application.Common.Persistence.Hierarchy;
using Donation.Application.Common.Persistence.Hierarchy;
using Donation.Domain.HierarchyAggregate;

namespace Donation.Infrastructure.Persistence.Repositories.Hierarchy
{
  public class OrgRepo : SimpleRepo<Org>, IOrgRepo
  {
    public OrgRepo(DonationDbContext dbContext): base(dbContext) { }
  }
}
```
### DI
```csharp
namespace Donation.Infrastructure
{
  public static class DependencyInjection
  {
    public static IServiceCollection AddInfrastructure(this IServiceCollection Services, ConfigurationManager Configuration)
    {
      Services
        .AddAuth(Configuration)
        .AddPersistence();
      Services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

      return Services;
    }
    public static IServiceCollection AddPersistence(this IServiceCollection Services)
    {
      Services.AddDbContext<DonationDbContext>(options =>
      {
        options.UseSqlServer("SERVER=localhost;DATABASE=Donation;USER=sa;PASSWORD=asdf1234;Encrypt=false");
      });
      Services.AddScoped<IOrgRepo, OrgRepo>();
      Services.AddScoped<ISystemzRepo, SystemzRepo>();
      return Services;
    }
  }
}
```

### Table Mapping - Needs Improvements
- This Example will Cover Parent & Child
```csharp
using Donation.Domain.HierarchyAggregate;
using Donation.Domain.SimpleAggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Donation.Infrastructure.Persistence.Configurations
{
  public class LEConfigurations : IEntityTypeConfiguration<LE>
  {
    public void Configure(EntityTypeBuilder<LE> builder)
    {
      ConfigureLETable(builder);
    }
    private void ConfigureLETable(EntityTypeBuilder<LE> builder)
    {
      builder.ToTable("LEs");
      builder.HasKey(x => x.Id);
      builder.Property(x => x.Id)
        .ValueGeneratedNever()
        .HasConversion(
          id => id.Value,
          value => SimpleValueObject.Create(value)
      );

      builder.Property(x => x.Title)
        .HasMaxLength(100);

      builder.Property(m => m.Description)
        .HasMaxLength(100);

      builder.Property(m => m.BGId)
        .HasConversion(
          id => id.Value,
          value => SimpleValueObject.Create(value)
        );
    }
  }
}
```