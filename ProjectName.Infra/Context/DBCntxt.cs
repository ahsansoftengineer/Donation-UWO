using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectName.Domain.Enums;
using ProjectName.Infra.Config;
using ProjectName.Infra.Entity;
using ProjectName.Infra.Entity.Donationz;
using ProjectName.Infra.Entity.Donor;
using ProjectName.Infra.Entity.Extraz;
using ProjectName.Infra.Entity.Hierarchy;
using ProjectName.Infra.Entity.MadaniBastaEntity;
using ProjectName.Infra.Entity.Regionz;

namespace ProjectName.Infra.Context
{
  public class DBCntxt : IdentityDbContext<ApiUser>
  {
    public DBCntxt(DbContextOptions options) : base(options) { }
    public DbSet<Org> Orgs { get; set; }
    public DbSet<Systemz> Systemzs { get; set; }
    public DbSet<BG> BGs { get; set; }
    public DbSet<LE> LEs { get; set; }
    public DbSet<OU> OUs { get; set; }
    public DbSet<SU> SUs { get; set; }

    public DbSet<Locationz> Locationzs { get; set; }
    public DbSet<Majlis> Majliss { get; set; }
    public DbSet<SysmanAccount> SysmanAccounts { get; set; }
    public DbSet<COA> COAs { get; set; }
    public DbSet<Branch> Branchs { get; set; }

    public DbSet<MadaniBasta> MadaniBastas { get; set; }
    public DbSet<MadaniBastaSubCategory> MadaniBastaSubCategorys { get; set; }
    public DbSet<MadaniBastaEvent> MadaniBastaEvents { get; set; }
    public DbSet<MadaniBastaPlace> MadaniBastaPlaces { get; set; }

    public DbSet<DonationType> DonationTypes { get; set; }
    public DbSet<DonationCategory> DonationCategorys { get; set; }
    public DbSet<DonationSubType> DonationSubTypes { get; set; }
    public DbSet<DonationCellMaster> DonationCellMasters { get; set; }
    public DbSet<TargetAssignment> TargetAssignments { get; set; }

    public DbSet<Country> Countrys { get; set; }
    public DbSet<State> States { get; set; }
    public DbSet<City> Citys { get; set; }

    public DbSet<DonorType> DonorTypes { get; set; }
    public DbSet<DonorBasic> DonorBasics { get; set; }
    public DbSet<DonorGSB> DonorGSB { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      // Step 2 Recalling Base OnModelCreating 
      // builder.ApplyConfiguration(new OrgConfig()); //
      // builder.Entity<Country>().HasData(SeedCountry.Data); //
      base.OnModelCreating(builder);
      //builder.Entity<Gender>().HasNoKey();
      //builder.Entity<Status>().HasNoKey();
      builder.AddInitialEntityData();


    }
    // All below code Commented for future reference
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //
    //{
    //  optionsBuilder.LogTo(Console.WriteLine);
    //}
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
