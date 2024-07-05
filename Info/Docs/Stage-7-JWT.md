## JWT Authentication & Authorization

### How to Setup Project for JWT
- This is Continued Section from Previous Chapters
1. Create a JwtSetting Class
```c#
namespace Donation.Infrastructure.Authentication;
public class JwtSettings
{
  public static string SectionName = "JwtSettings";
  public string Secret { get; set; }
  public string Issuer { get; set; }
  public string Audience { get; set; }
  public int ExpiryMinutes { get; set; }
}
```
2. Install the Following Packages in Infrastructure Project
```c#
dotnet add .\Donation.Infrastructure\ package Microsoft.AspNetCore.Authentication.JwtBearer
dotnet add .\Donation.Infrastructure\ package System.IdentityModel.Tokens.Jwt
```
3. Add Configuration & Services in Infrastructure
```c#
namespace Donation.Infrastructure;
public static class DependencyInjection
{
  public static IServiceCollection AddInfrastructure(this IServiceCollection Services,ConfigurationManager Configuration)
  {
    Services.AddAuth(Configuration); // <=
    return Services;
  }
  // Here we are Configuring for JWT
  public static IServiceCollection AddAuth(this IServiceCollection Services, ConfigurationManager Configuration)
  {
    var jwtSettings = new JwtSettings();
    Configuration.Bind(JwtSettings.SectionName, jwtSettings);

    Services.AddSingleton(Options.Create(jwtSettings));

    Services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
    Services
      .AddAuthentication(options =>
      {
        options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
      })
      .AddJwtBearer(options =>
      {
        options.TokenValidationParameters = new TokenValidationParameters()
        {
          // 1. Here we are saying what to Validate Issuer & Audience
          ValidateIssuer = true,
          ValidateAudience = true,
          ValidateLifetime = true,

          // 2. Here we are telling what is Issuer & Audience
          ValidIssuer = jwtSettings.Issuer,
          ValidAudience = jwtSettings.Audience,

          // 3. To Help other component how to validate the signature of the Token
          ValidateIssuerSigningKey = true,
          IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Secret))
        };
      });
    return Services;
  }
}
```

3. Add the Services in Program.cs
```c#
{
  app.UseExceptionHandler("/error");

  app.UseHttpsRedirection();
  app.UseAuthentication(); // This is already Set up by AddControllers
  app.UseAuthorization(); // This middleware decide weather the user can access the endpoints

  app.MapControllers();
}
```
4. The Good thing abount Attribute the same can be used at *Class, Function, Properties Level*
4. JWT at Application Level
```c#
namespace Donation.Api.Controllers
[ApiController]
[Authorize] // <=
public class ApiController : ControllerBase
{
  protected IActionResult Problem(List<Error> errors)
  {
  }
}
```
5. JWT at Controller, Action Level
```c#
namespace Donation.Api.Controllers
[Route("api/[controller]")]
//[Authorize] // <==
public class DinnersController : ApiController
{
  [HttpGet]
  //[Authorize] // <==
  public IActionResult ListDinners()
  {
    return Ok(Array.Empty<string>());
  }
}
```
6. Routes & Controller without Protection
```c#
namespace Donation.Api.Controllers;

[Route("auth")]
[AllowAnonymous] // <== Without Authorization
public class AuthenticationController : ApiController
{
  private readonly IMediator mediator;
  private readonly IMapper mapper;

  public AuthenticationController(IMediator mediator, IMapper mapper)
  {
    this.mediator = mediator;
    this.mapper = mapper;
  }

  [NonAction] // <== Only Function, not a Action Method Enpoints within Controller
  public string myLocalFuncation()
  {
    return "No Action Counted in Swagger";
  }
}
```

### Configure Swagger for JWT
1. Donation.Infrastructure.DependencyInjection
```c#
namespace Donation.Infrastructure
public static class DependencyInjection
{
  public static IServiceCollection AddInfrastructure(this IServiceCollection Services, ConfigurationManager Configuration)
  {
    Services.AddAuth(Configuration);
    return Services;
  }

  public static IServiceCollection AddAuth(
    this IServiceCollection Services,
    ConfigurationManager Configuration
    )
  {
    var jwtSettings = new JwtSettings();
    Configuration.Bind(JwtSettings.SectionName, jwtSettings);
    // shorthand syntax for accessing configuration
    Services.AddSingleton(Options.Create(jwtSettings));

    Services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
    Services
      .AddAuthentication(options =>
      {
        options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
      })
      .AddJwtBearer(options =>
      {
        options.TokenValidationParameters = new TokenValidationParameters()
        {
          // To Help other component how to validate the signature of the Token
          ValidateIssuerSigningKey = true,
          IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Secret))

          // Swagger Causing Problem with it for time being we have to set Issuer & Audience like so
          ValidateIssuer = false, // <==
          ValidateAudience = false, // <==
          ValidAudience = "https://localhost:7228", // <==
          ValidIssuer = "https://localhost:7228", // <==

        };
      });
    return Services;
  }
}
```
2. Donation.Api.DependencyInjection 
- Basic & JWT Auth just Uncomment the Commented Area
```c#
namespace Donation.Api
public static class DependencyInjection
{
  public static IServiceCollection AddPresentation(this IServiceCollection Services)
  {
    Services.AddMySwagger();
    Services.AddSingleton<ProblemDetailsFactory, DonationOverrideDefaultProblemDetailsFactory>();
    return Services;
  }

  public static IServiceCollection AddMySwagger(this IServiceCollection Services)
  {

    Services.AddSwaggerGen(c =>
    {
      c.SwaggerDoc("v1", new OpenApiInfo {
        Title = "Domain Driven Design", 
        Version = "v1.0.0" 
      });

      //c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
      c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
      {
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Description = "Basic & JWT Auth",
        Scheme = "bearer", //"basic",
        BearerFormat = "JWT", // not required in "basic" Auth
      });

      c.AddSecurityRequirement(
        new OpenApiSecurityRequirement { {
          new OpenApiSecurityScheme {
            Reference = new OpenApiReference {
              Type = ReferenceType.SecurityScheme,
              Id = "Bearer" // "basic"
            }
          },
          new string[] {"Bearer" } // Removed "Bearer" in basic Auth
        }
      });
    });
    return Services;
  }
}
```
2. Program.cs
```c#
var builder = WebApplication.CreateBuilder(args);
{
  builder.Services
    .AddPresentation() // <=
    .AddApplication()
    .AddInfrastructure(builder.Configuration);

}

var app = builder.Build();

{
  app.UseExceptionHandler("/error");

  app.UseHttpsRedirection();
  app.UseAuthentication(); // <==
  app.UseAuthorization(); // <==

  app.MapControllers();

  if (app.Environment.IsDevelopment())
  {
    app.UseDeveloperExceptionPage();
    app.UseSwagger(); // <==
    app.UseSwaggerUI(); // <==
  }
  app.Run();
}
```

### Images
![JWT Claims](https://github.com/ahsansoftengineer/donation-DDD/blob/7-JWT_Token_Bearear/Info/Images/Stage%207%20-%20JWT%20Bearer%20Token%20Claims.png)
![JWT Token Flow](https://github.com/ahsansoftengineer/donation-DDD/blob/7-JWT_Token_Bearear/Info/Images/Stage%207%20-%20JWT%20Bearer%20Token.png)
