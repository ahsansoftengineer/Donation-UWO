
using System.Linq.Expressions;

namespace ProjectName.Domain.Model.Base
{
  public class BasePagination
  {
    const int maxPageSize = 50;
    public int PageNo { get; set; } = 1;
    private int pageSize = 10;
    public int PageSize
    {
      get
      {
        return pageSize;
      }
      set
      {
        pageSize = value > maxPageSize ? maxPageSize : value;
      }
    }
  }
  public class PaginateResponse<T> : BasePagination
  {
    public List<T> Records { get; set; }
    public int Count { get; set; }
    // public bool HasNextPage { get; set; } //

  }
  public class PaginateRequest<T> : BasePagination
  {
    public T? search { get; set; }
    public T? orderBy { get; set; }
    public OrderType? orderType { get; set; }
  }

  public enum OrderType
  {
    Asc,
    Desc
  }

  public class GenericPaginateRequest<T>
  {
    public PaginateRequest<T> request { get; set; } = null;
    List<string>? includes = null;
    Expression<Func<T, bool>>? expression = null;
    //// OrderBy UpdatedAt for Looking at the currently updated record at top in the list //
    //// We need to set it to default //
    Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null;


  }
}
