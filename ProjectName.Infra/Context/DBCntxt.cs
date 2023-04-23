using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectName.Infra.Configuration;
using ProjectName.Infra.Entity;

namespace ProjectName.Infra.Context
{
  public class DBCntxt : IdentityDbContext<ApiUser>
  {
    public DBCntxt(DbContextOptions options) : base(options) { }
    public DbSet<Country> Countries { get; set; }
    //public DbSet<Hotel> Hotels { get; set; } //

    protected override void OnModelCreating(ModelBuilder builder)
    {
      // Step 2 Recalling Base OnModelCreating 
      base.OnModelCreating(builder);

      // builder.Entity<Country>().HasData(SeedCountry.Data); //
      
      builder.ApplyConfiguration(
        new CountryConfig());
      //builder.ApplyConfiguration(
      //  new HotelConfiguration()); //
      builder.ApplyConfiguration(
        new RoleConfig());
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
