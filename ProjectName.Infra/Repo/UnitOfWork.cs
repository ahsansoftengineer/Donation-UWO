using Microsoft.EntityFrameworkCore;
using ProjectName.Infra.Context;
using ProjectName.Infra.Entity.Hierarchy;
using ProjectName.Infra.Entity.Base;
using ProjectName.Infra.Entity.MadaniBastaEntity;
using ProjectName.Infra.Entity.Extraz;
using ProjectName.Infra.Entity.Donationz;

namespace ProjectName.Infra.Repo
{
  public partial class UnitOfWork
  {
    private readonly DBCntxt _context;
    public UnitOfWork(DBCntxt context)
    {
      _context = context;
    }
    // Hierarchy
    private IGenericRepo<Org>? _orgs;
    private IGenericRepo<Systemz>? _systemz;
    private IGenericRepo<BG>? _bgs;
    private IGenericRepo<LE>? _les;
    private IGenericRepo<OU>? _ous;
    private IGenericRepo<SU>? _sus;

    // MadaniBasta
    private IGenericRepo<MadaniBasta>? _madaniBastas;
    private IGenericRepo<MadaniBastaSubCategory>? _madaniBastaSubCategorys;
    private IGenericRepo<MadaniBastaEvent>? _madaniBastaEvents;
    private IGenericRepo<MadaniBastaPlace>? _madaniBastaPlaces;

    // Extra
    private IGenericRepo<COA>? _cOAs;
    private IGenericRepo<Locationz>? _locations;
    private IGenericRepo<Majlis>? _majliss;
    private IGenericRepo<SysmanAccount>? _sysmanAccounts;

    // Donation

    private IGenericRepo<DonationCategory>? _donationCategory;
    public IGenericRepo<DonationCellMaster>? _donationCellMaster;
    public IGenericRepo<DonationSubType>? _donationSubType;
    public IGenericRepo<DonationType>? _donationType;
    public async Task Save()
    {
      AddTimestamps();
      await _context.SaveChangesAsync();
    }
    // Handling CreatedAt & UpdatedAt
    private void AddTimestamps()
    {
      var entities = _context.ChangeTracker.Entries()
          .Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

      foreach (var entity in entities)
      {
        var now = DateTime.UtcNow; // current datetime
        Console.WriteLine(entity.State);
        if (entity.State == EntityState.Added)
        {
          ((BaseEntity)entity.Entity).CreatedAt = now;
        }
        //EntityState.Detached, EntityState.Deleted, EntityState.Unchanged
        ((BaseEntity)entity.Entity).UpdatedAt = now;
      }
    }
    public void Dispose()
    {
      _context.Dispose();
      GC.SuppressFinalize(this);
    }
  }
}
