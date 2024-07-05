## Mapster in API

### How to use Mapster in Web
1. Records
```c#
namespace Donation.Application.Authentication.Common;
public record AuthenticationResult(
  User user, 
  string token
);

namespace Donation.Contracts.Authentication;
public record AuthenticationResponse(
  Guid Id,
  string FirstName,
  string LastName,
  string Email,
  string Token
);
```
2. dotnet add .\Donation.Api\ Mapster
3. dotnet add .\Donation.Api\ Mapster.DependencyInjection
4. Defining Mapping
```c#
using Donation.Application.Authentication.Commands.Register;
using Donation.Application.Authentication.Common;
using Donation.Application.Authentication.Query.Login;
using Donation.Contracts.Authentication;
using Mapster;

namespace Donation.Api.Common.Mapping;
public class AuthenticationMappingConfig : IRegister
{

  public void Register(TypeAdapterConfig config)
  {
    config.NewConfig<RegisterRequest, RegisterCommand>();
    config.NewConfig<LoginRequest, LoginQuery>();

    config.NewConfig<AuthenticationResult, AuthenticationResponse>()
      .Map(dest => dest, src => src.User);
  }
}
```
5. Mapping Extension Method
```c#
namespace Donation.Api.Common.Mapping;
public static class DependencyInjection
{
  public static IServiceCollection AddMapping(this IServiceCollection services)
  {
    var config = TypeAdapterConfig.GlobalSettings;
    config.Scan(Assembly.GetExecutingAssembly());

    services.AddSingleton(config);
    services.AddScoped<IMapper, ServiceMapper>();

    return services;
  }
}
```
6. Adding Service in Application Layer
```c#
  Services.AddMapping();
```
7. Removing async warning
```c#
// add the following code within async function
await Task.CompletedTask;
```

