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
    private IGenericRepo<Country> _countries;
    private IGenericRepo<Org> _orgs;

    public UnitOfWork(DBCntxt context)
    {
      _context = context;
    }
    // ??= C# 9 Short-hand Syntax
    public IGenericRepo<Country> Countries => _countries ??= new GenericRepo<Country>(_context);
    public IGenericRepo<Org> Orgs => _orgs ??= new GenericRepo<Org>(_context);

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
