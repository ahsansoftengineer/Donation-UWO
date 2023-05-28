﻿using ProjectName.API.Config;
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
      services.AddAutoMapper(typeof(MapperInitializerFull));
      services.AddExternalServices();
      services.AddInfrastructure(Configuration);

    }
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      app.AddExternalConfiguration(env);
      app.UseCors("CorsPolicyAllowAll");
      app.UseHttpsRedirection();
    }
  }
}
