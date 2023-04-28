using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectName.Infra.Config.Hierarchy;
using ProjectName.Infra.Configuration;
using ProjectName.Infra.Entity;
using ProjectName.Infra.Entity.Hierarchy;

namespace ProjectName.Infra.Context
{
  public class DBCntxt : IdentityDbContext<ApiUser>
  {
    public DBCntxt(DbContextOptions options) : base(options) { }
    public DbSet<Org> Orgs { get; set; }
    public DbSet<Systemz> Systemzs { get; set; }
    public DbSet<BG> BGs { get; set; }
    public DbSet<LE> LEs { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      // Step 2 Recalling Base OnModelCreating 
      base.OnModelCreating(builder);

      // builder.Entity<Country>().HasData(SeedCountry.Data); //

      builder.ApplyConfiguration(new RoleConfig());
      builder.ApplyConfiguration(new OrgConfig());
      builder.ApplyConfiguration(new SystemzConfig());
      builder.ApplyConfiguration(new BGConfig());
      builder.ApplyConfiguration(new LEConfig());
    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //  base.OnConfiguring(optionsBuilder);
    //}
    //protected override void OnModelCreating(ModelBuilder builder)
    //{
    //  builder.ApplyConfigurationsFromAssembly(
    //    typeof(DonationDbContext).Assembly
    //  );
    //  base.OnModelCreating(builder);
    //}    
  }
}
