using Microsoft.EntityFrameworkCore;
using ProjectName.Infra.Context;
using ProjectName.Infra.Entity;
using ProjectName.Infra.Entity.Hierarchy;
using ProjectName.Infra.Entity.Base;

namespace ProjectName.Infra.Repo
{
    public class UnitOfWork : IUnitOfWork
  {
    private readonly DBCntxt _context;
    private IGenericRepo<Org> _orgs;
    private IGenericRepo<Systemz> _systemz;
    private IGenericRepo<BG> _bgs;
    private IGenericRepo<LE> _les;

    public UnitOfWork(DBCntxt context)
    {
      _context = context;
    }
    // ??= C# 9 Short-hand Syntax
    public IGenericRepo<Org> Orgs => _orgs ??= new GenericRepo<Org>(_context);
    public IGenericRepo<Systemz> Systemzs => _systemz ??= new GenericRepo<Systemz>(_context);
    public IGenericRepo<BG> BGs => _bgs ??= new GenericRepo<BG>(_context);
    public IGenericRepo<LE> LEs => _les ??= new GenericRepo<LE>(_context);

    public void Dispose()
    {
      _context.Dispose();
      GC.SuppressFinalize(this);
    }

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
  }
}
