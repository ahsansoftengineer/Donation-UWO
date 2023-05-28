
using LinqKit;
using Microsoft.EntityFrameworkCore;
using ProjectName.Infra.Entity.Attributez;
using ProjectName.Infra.Entity.Donor;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ProjectName.Infra.Repo.Operationz
{
  public static class GenericIncludes
  {
    public static IQueryable<T> IncluesByGeneric<T>(this IQueryable<T> source, List<string>? includes)
      where T : class
    {
      if (includes == null) return source;

      Type entityType = typeof(T);
      IEnumerable<PropertyInfo> navigationProperty = entityType.GetProperties()
         .Where(property => Attribute.IsDefined(property, typeof(RelateAttribute)));
      IEqualityComparer<string> comparer = new CustomStringEqualityComparer();
      var matchingProperties = navigationProperty.Select(x => x.Name).Intersect(includes, comparer);

      if (matchingProperties != null)
      {
        foreach (var item in matchingProperties)
        {
          source = source.Include(item);
        }
      }
      return source;
    }
  }
  public class CustomStringComparer : IComparer<string>
  {
    public int Compare(string x, string y)
    {
      // Customize the comparison logic here
      return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
    }
  }

  public class CustomStringEqualityComparer : IEqualityComparer<string>
  {
    public bool Equals(string x, string y)
    {
      // Customize the string comparison logic here
      return string.Equals(x, y, StringComparison.OrdinalIgnoreCase);
    }

    public int GetHashCode(string obj)
    {
      // Customize the hash code generation logic here
      return StringComparer.OrdinalIgnoreCase.GetHashCode(obj);
    }
  }
}
