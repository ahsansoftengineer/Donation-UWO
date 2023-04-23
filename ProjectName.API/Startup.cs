using Microsoft.AspNetCore.Mvc;
using ProjectName.API.DI;
using ProjectName.Infra;

namespace ProjectName.API
{
  public class Startup
  {
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddDICommon();
      services.AddInfrastructure(Configuration);

    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      app.ConfigureDevEnv(env);
      app.ConfigureExceptionHandler();
      app.UseHttpsRedirection();

      app.UseCors("CorsPolicyAllowAll");

      // API Caching 2. Setting up Caching
      app.UseResponseCaching();
      // API Caching 7. Setting up Caching Profile at Globally
      app.UseHttpCacheHeaders();
      // API Throttling 4. Setting up Middleware
      // This is giving error while runing
      //app.UseIpRateLimiting(); //

      app.UseRouting();
      app.UseAuthorization();
      app.UseEndpoints(ep =>
      {
        // This Routing is useful for MVC type application
        // Convention Based Routing Schema
        //ep.MapControllerRoute(
        //  name: "default",
        //  pattern: "{controller=Home}/{action=Index}/{id?}"
        //  ); //
        ep.MapControllers();
      });
    }


  }
}
