using Microsoft.EntityFrameworkCore;
using ProjectName.Infra.Context;
using ProjectName.Infra.Entity.Base;

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
    private GenericRepo<T> Got<T>() where T : class
    {
      return new GenericRepo<T>(_context);
    }
    public void Dispose()
    {
      _context.Dispose();
      GC.SuppressFinalize(this);
    }
  }
}
