using ProjectName.Domain.Model;
using System.Linq.Expressions;
using X.PagedList;

namespace ProjectName.Infra.Repo
{
  public interface IGenericRepo<T> where T : class
  {
    Task<List<T>> GetAll(
      Expression<Func<T, bool>>? expression = null,
      Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
      List<string>? includes = null
    );

    Task<IPagedList<T>> GetPagedList(
      RequestParams? param = null,
      List<string>? includes = null,
      Expression<Func<T, bool>>? expression = null,
      Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null
     );

    Task<T> Get(
      Expression<Func<T, bool>> expression,
      List<string>? includes = null
    );
    Task Insert(T entity);
    Task InsertRange(IEnumerable<T> entities);
    Task Delete(int id);
    void DeleteRange(IEnumerable<T> entities);
    void Update(T entity);

  }
}
