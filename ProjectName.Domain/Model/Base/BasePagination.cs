namespace ProjectName.Domain.Model.Base
{
  public class BasePagination
  {
    const int maxPageSize = 50;
    public int? PageNo { get; set; } = 1;
    private int pageSize = 10;
    public int PageSize
    {
      get
      {
        return pageSize;
      }
      set
      {
        if (value == null) pageSize = 10;
        else pageSize = value > maxPageSize ? maxPageSize : value;
      }
    }
  }
  public class PaginateResponse<T> : BasePagination
  {
    public List<T> Records { get; set; }
    public int Count { get; set; }
    // public bool HasNextPage { get; set; } //

  }

  public class PaginateRequestFilter<T, TDto> : BasePagination
    where T : class
  {
    public TDto? Search { get; set; }
    public Sort? Sort { get; set; }
  }
  public enum Order
  {
    Unspecified = -1,
    Ascending,
    Descending
  }
  public class Sort
  {
    public string? By { get; set; }
    public Order? Order { get; set; } = Base.Order.Unspecified;

  }
  
}
