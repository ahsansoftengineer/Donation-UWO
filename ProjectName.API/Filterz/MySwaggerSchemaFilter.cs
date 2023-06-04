//using Microsoft.OpenApi.Models;
//using ProjectName.Domain.Attributez;
//using Swashbuckle.AspNetCore.SwaggerGen;
//using System.Reflection;
//using System.Runtime.Serialization;

//namespace ProjectName.API.Filterz
//{
//  public class MySwaggerSchemaFilter : ISchemaFilter
//  {
//    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
//    {
//      if (schema?.Properties == null)
//      {
//        return;
//      }

//      var ignoreDataMemberProperties = context.Type.GetProperties()
//          .Where(t => t.GetCustomAttribute<HideSwaggerAttribute>() != null);

//      foreach (var ignoreDataMemberProperty in ignoreDataMemberProperties)
//      {
//        var propertyToHide = schema.Properties.Keys
//            .SingleOrDefault(x => x.ToLower() == ignoreDataMemberProperty.Name.ToLower());

//        if (propertyToHide != null)
//        {
//          schema.Properties.Remove(propertyToHide);
//        }
//      }
//    }
//  }
//}
