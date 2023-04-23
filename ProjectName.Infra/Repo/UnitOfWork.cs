using ProjectName.Infra.Context;
using ProjectName.Infra.Entity;

namespace ProjectName.Infra.Repo
{
  public class UnitOfWork : IUnitOfWork
  {
    private readonly DBCntxt _context;
    private IGenericRepo<Country> _countries;

    public UnitOfWork(DBCntxt context)
    {
      _context = context;
    }
    // ??= C# 9 Short-hand Syntax
    public IGenericRepo<Country> Countries => _countries ??= new GenericRepo<Country>(_context);


    public void Dispose()
    {
      _context.Dispose();
      GC.SuppressFinalize(this);
    }

    public async Task Save()
    {
      await _context.SaveChangesAsync();
    }
  }
}
