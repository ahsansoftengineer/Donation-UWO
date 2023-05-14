using ProjectName.Domain.Model.Base;
using System.Linq.Expressions;
using X.PagedList;

namespace ProjectName.Infra.Repo
{
  public interface IGenericRepo<T> where T : class
  {
    Task<T> Get(
      Expression<Func<T, bool>> expression,
      List<string>? includes = null
    );
    Task<List<T>> Gets(
      Expression<Func<T, bool>>? expression = null,
      // OrderBy UpdatedAt for Looking at the currently updated record at top in the list
      // We need to set it to default
      Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
      List<string>? includes = null
    );

    //Task<IPagedList<T>> Gets(BasePagination req, List<string>? includes = null);
    Task<IPagedList<T>> Gets<TDto>(PaginateRequestFilter<T, TDto?> req)
      where TDto : class;

    Task Insert(T entity);
    Task InsertRange(IEnumerable<T> entities);
    Task Delete(int id);
    void DeleteRange(IEnumerable<T> entities);
    void Update(T entity);

  }
}
