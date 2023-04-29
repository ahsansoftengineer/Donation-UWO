using AutoMapper;
using X.PagedList;

namespace ProjectName.API.Config
{
  public class PagedListConverter<TSource, TDestination> :
    ITypeConverter<IPagedList<TSource>, IPagedList<TDestination>>
    where TSource : class
    where TDestination : class
  {
    public IPagedList<TDestination> Convert(IPagedList<TSource> source, IPagedList<TDestination> destination, ResolutionContext context)
    {
      var collection = context.Mapper.Map<IEnumerable<TSource>, IEnumerable<TDestination>>(source);
      return new PagedList<TDestination>(collection, source.PageNumber, source.PageSize);
    }
  }
}
