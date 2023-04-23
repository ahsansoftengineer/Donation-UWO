using Microsoft.EntityFrameworkCore;
using ProjectName.Domain.Model;
using ProjectName.Infra.Context;
using System.Linq.Expressions;
using X.PagedList;

namespace ProjectName.Infra.Repo
{
  public class GenericRepo<T> : IGenericRepo<T> where T : class
  {
    private readonly DBCntxt _context;
    private readonly DbSet<T> _db;
    public GenericRepo(DBCntxt context)
    {
      _context = context;
      _db = context.Set<T>();
    }
    public async Task Delete(int id)
    {
      var entity = await _db.FindAsync(id);
      _db.Remove(entity);
    }

    public void DeleteRange(IEnumerable<T> entities)
    {
      _db.RemoveRange(entities);
    }

    public async Task<T> Get(
      Expression<Func<T, bool>> expression,
      List<string>? includes = null)
    {
      // Here Includes refers to Child Entity tobe Include in Dataset
      IQueryable<T> query = _db;
      if (includes != null)
      {
        foreach (var item in includes)
        {
          query = query.Include(item);
        }
      }

      return await query.AsNoTracking().FirstOrDefaultAsync(expression);
    }

    public async Task<List<T>> GetAll(
      Expression<Func<T, bool>>? expression = null,
      Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
      List<string>? includes = null)
    {
      IQueryable<T> query = _db;
      if (expression != null)
      {
        query = query.Where(expression);
      }

      if (includes != null)
      {
        foreach (var item in includes)
        {
          query = query.Include(item);
        }
      }

      if (orderBy != null)
      {
        query = orderBy(query);
      }
      return await query.AsNoTracking().ToListAsync();
    }

    // X.PagedList.Mvc.Core ->  X_Pagedist Library Requires
    public async Task<IPagedList<T>> GetPagedList(
      RequestParams? param = null,
      List<string>? includes = null,
       Expression<Func<T, bool>>? expression = null,
      Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null)
    {
      IQueryable<T> query = _db;
      if (expression != null)
      {
        query = query.Where(expression);
      }

      if (includes != null)
      {
        foreach (var item in includes)
        {
          query = query.Include(item);
        }
      }

      if (orderBy != null)
      {
        query = orderBy(query);
      }
      return await query.AsNoTracking()
        .ToPagedListAsync(param.PageNumber, param.PageSize);
    }

    public async Task Insert(T entity)
    {
      await _db.AddAsync(entity);
    }

    public async Task InsertRange(IEnumerable<T> entities)
    {
      await _db.AddRangeAsync(entities);
    }

    public void Update(T entity)
    {
      _db.Attach(entity);
      _context.Entry(entity).State = EntityState.Modified;
    }
  }
}
