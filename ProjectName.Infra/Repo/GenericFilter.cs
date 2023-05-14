using LinqKit;
using Microsoft.EntityFrameworkCore;
using ProjectName.Domain.Common;
using System.Linq.Expressions;
using System.Reflection;

namespace ProjectName.Infra.Repo
{
  public static class GenericFilter
  {
    public static IQueryable<T> FilterByGeneric<T, TDto>(this IQueryable<T> source, TDto searchObject)
      where T : class
      where TDto : class
    {
      if (searchObject == null) return source;

      //var dtoParam = Expression.Parameter(typeof(TDto), "TDto");
      var entityParam = Expression.Parameter(typeof(T), "TEntity");
      var dtoPropInfos = searchObject.GetType()
          .GetProperties(BindingFlags.Public | BindingFlags.Instance)
          .Where(p => p.GetValue(searchObject) != null); // && p.PropertyType.IsValueType

      var predicate = PredicateBuilder.New<T>();

      foreach (var dtoPropInfo in dtoPropInfos)
      {
        //var dtoProp = Expression.Property(dtoParam, dtoPropInfo.Name); //
        //var dtoValue = dtoPropInfo.GetValue(searchObject); //

        MemberExpression entityProp = null;

        if(dtoPropInfo.Name == "DateFrom" || dtoPropInfo.Name == "DateTo")
        {
          entityProp = Expression.Property(entityParam, "CreatedAt");
        } 
        else // if(typeof(T).HasProperty(dtoPropInfo.Name))
        {
          try
          {
            entityProp = Expression.Property(entityParam, dtoPropInfo.Name);

          } 
          catch (Exception e)
          {
            Console.WriteLine("Property not Exist {0} Message : {1}", dtoPropInfo.Name, e.Message);
          }
        }

        if (entityProp != null)
        {
          var entityValue = dtoPropInfo.GetValue(searchObject);

          //var lambda = Expression.Lambda<Func<T, bool>>(comparison, parameter); //
          //predicate = predicate.And(lambda); //

          if (!string.IsNullOrWhiteSpace(entityValue?.ToString()))
          {
            if (entityValue.GetType() == typeof(string))
            {
              predicate = predicate.And(p => EF.Functions.Like(
              EF.Property<string>(p, dtoPropInfo.Name),
              $"%{entityValue}%")
             );
            }
            else if (dtoPropInfo.Name == "DateFrom" || dtoPropInfo.Name == "DateTo")
            {

              var constant = Expression.Constant(entityValue, dtoPropInfo.PropertyType);
              BinaryExpression comparison = null;
              if (dtoPropInfo.Name == "DateFrom")
                comparison = Expression.GreaterThanOrEqual(entityProp, constant);
              else
                comparison = Expression.LessThanOrEqual(entityProp, constant);

              var lambda = Expression.Lambda(comparison, entityParam);
              predicate = predicate.And((Expression<Func<T, bool>>)lambda);
            }
            else
            {
              var constant = Expression.Constant(entityValue, dtoPropInfo.PropertyType);
              var comparison = Expression.Equal(entityProp, constant);
              var lambda = Expression.Lambda(comparison, entityParam);
              predicate = predicate.And((Expression<Func<T, bool>>)lambda);
            }

          }
        }
      }
      if(predicate.Parameters.Count > 0)
        return source.Where(predicate);
      return source;
    }
  }
}
