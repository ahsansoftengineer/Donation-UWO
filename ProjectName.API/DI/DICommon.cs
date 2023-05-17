using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ProjectName.API.DI
{
  public static partial class DICommon
  {

    public static IServiceCollection AddDICommon(this IServiceCollection services)
    {
      // API Throttling 1: Adding Service
      services.AddMemoryCache(); // Enable Production
      // API Throttling 3
      services.ConfigureRateLimiting();
      services.AddHttpContextAccessor();

      // API Caching 6: Adding Services Extensions
      services.ConfigureHttpCacheHeaders();

      services.AddAuthentication();
      services.ConfigureIdentity();

      services.ConfigureCors();

      //services.AddAutoMapper(typeof(MapperInitializer)); // Later
      // Transient Means Fresh Copy
      services.ConfigureSwagger();
      services
        // API Caching 3. Defining Cache Profile
        .AddControllers(config =>
        {
          //config.Filters<Filters>();
          config.CacheProfiles.Add("120SecondsDuration", new CacheProfile
          {
            Duration = 120
            //,Location = ResponseCacheLocation.Client
            //,NoStore = true
            //,VaryByHeader = "I don't know which string"
            //,VaryByQueryKeys = "Any Keys"
          });
        })
        .AddNewtonsoftJson(opt =>
        {
          opt.SerializerSettings.ReferenceLoopHandling =
            Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        });

      services.ConfigureVersioning();
      
      return services;
    }

    public static void ConfigureSwagger(this IServiceCollection services)
    {
      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
        {
          Title = "Trevor Simple",
          Version = "v1"
        });
      });
    }

    public static void ConfigureCors(this IServiceCollection services)
    {
      services.AddCors(option =>
      {
        option
          .AddPolicy("CorsPolicyAllowAll", builder =>
            builder
              .AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader()
        );
      });
    }
  }
}
