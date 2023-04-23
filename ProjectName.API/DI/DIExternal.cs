using AspNetCoreRateLimit;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Identity;
using ProjectName.Domain.Model;
using ProjectName.Infra.Context;
using ProjectName.Infra.Entity;

namespace ProjectName.API.DI
{
  public static partial class DIExternal
  {
    public static IServiceCollection AddExternal(this IServiceCollection services, IApplicationBuilder app)
    {

      services
        .ConfigureIdentity()
        .ConfigureVersioning()
        .ConfigureHttpCacheHeaders()
        .ConfigureRateLimiting();

      app.ConfigureExceptionHandler();

      return services;
    }
    public static void ConfigureDevEnv(this IApplicationBuilder app, IWebHostEnvironment env)
    {

      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Trevor v1"));
      }
    }
    public static IApplicationBuilder ConfigureExceptionHandler(this IApplicationBuilder app)
    {
      app.UseExceptionHandler(error =>
      {
        error.Run(async context =>
        {
          context.Response.StatusCode = StatusCodes.Status500InternalServerError;
          context.Response.ContentType = "application/json";
          var contextFeature = context.Features.Get<IExceptionHandlerFeature>();

          if (contextFeature != null)
          {
            //Log.Error($"Something Went Wrong in the {contextFeature.Error}"); //

            await context.Response.WriteAsync(new Error
            {
              StatusCode = context.Response.StatusCode,
              Message = "Internal Server Error. Please Try Again Later."
            }.ToString());
          }
        });
      });
      return app;
    }
    // Entity Framework Identity
    public static IServiceCollection ConfigureIdentity(this IServiceCollection services)
    {
      var builder = services
        .AddIdentityCore<ApiUser>(q => q.User.RequireUniqueEmail = true);

      builder = new IdentityBuilder(
        builder.UserType,
        typeof(IdentityRole), services);

      builder
        .AddEntityFrameworkStores<DBCntxt>()
          .AddDefaultTokenProviders();
      return services;
    }
    // Version URI, Query, Headers
    public static IServiceCollection ConfigureVersioning(this IServiceCollection services)
    {
      services.AddApiVersioning(opt =>
      {
        opt.ReportApiVersions = true;
        opt.AssumeDefaultVersionWhenUnspecified = true;
        opt.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
      });
      return services;
    }
    // API Caching : 5 with Marvin.Cache.Headers
    public static IServiceCollection ConfigureHttpCacheHeaders(this IServiceCollection services)
    {
      services.AddResponseCaching();
      services.AddHttpCacheHeaders(
        (expirationOpt) =>
        {
          expirationOpt.MaxAge = 65;
          expirationOpt.CacheLocation = Marvin.Cache.Headers.CacheLocation.Private;
        },
        (validationOpt) =>
        {
          validationOpt.MustRevalidate = true;
        }
        );
      return services;
    }
    // API Throttling 2: 
    public static IServiceCollection ConfigureRateLimiting(this IServiceCollection services)
    {
      var rateLimitRules = new List<RateLimitRule>
      {
        new RateLimitRule
        {
          Endpoint = "*",
          Limit = 3,
          Period = "1m"
        }
      };

      services.Configure<IpRateLimitOptions>(opt =>
      {
        opt.GeneralRules = rateLimitRules;
      });
      services.AddSingleton<IRateLimitCounterStore, MemoryCacheRateLimitCounterStore>();
      services.AddSingleton<IIpPolicyStore, MemoryCacheIpPolicyStore>();
      services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();

      return services;
    }
  }
}
