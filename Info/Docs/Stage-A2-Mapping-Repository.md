### Mapping

```csharp
// Alias due to Conflict Naming
using MenuSection = Donation.Domain.Menu.Entities.MenuSection;
using MenuItem = Donation.Domain.Menu.Entities.MenuItem;

namespace Donation.Api.Common.Mapping
{
  public class MenuMappingConfig : IRegister
  {
    public void Register(TypeAdapterConfig config)
    {
      config.NewConfig<
        (CreateMenuRequest Request, string HostId),  // src area
        CreateMenuCommand>() // dest area
        .Map(dest => dest.HostId, src => src.HostId)
        .Map(dest => dest, src => src.Request);

      // There is better way of rewriting it
      config.NewConfig<Menu, MenuResponse>()
        .Map(dest => dest.Id, src => src.Id.Value)
        .Map(dest => dest.AverageRating, src => src.AverageRating.Value)
        .Map(dest => dest.HostId, src => src.HostId.Value)
        .Map(dest => dest.DinnerIds, src => src.DinnerIds.Select(dinnerId => dinnerId.Value))
        .Map(dest => dest.MenuReviewIds, src => src.MenuReviewIds.Select(reviewId => reviewId.Value));

      config.NewConfig<MenuSection, MenuSectionResponse>()
        .Map(dest => dest.Id, src => src.Id.Value);

      config.NewConfig<MenuItem, MenuItemResponse>()
        .Map(dest => dest.Id, src => src.Id.Value);

    }
  }
}
```
### IMenuRepository
```csharp
namespace Donation.Application.Common.Persistence
{
  public interface IMenuRepository
  {
    void Add(Menu menu);
  }
}
```

### MenuRepository Impl
```csharp
namespace Donation.Infrastructure.Persistence
{
  public class MenuRepository : IMenuRepository
  {
    private static readonly List<Menu> _menus = new List<Menu>();
    public void Add(Menu menu)
    {
      _menus.Add(menu);
    }
  }
}
```
### Adding in DI Container
```csharp
namespace Donation.Infrastructure
{
  public static class DependencyInjection
  {
    public static IServiceCollection AddInfrastructure(this IServiceCollection Services, ConfigurationManager Configuration)
    {
      Services
        .AddAuth(Configuration)
        .AddPersistence(); // Here
      Services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

      return Services;
    }
    public static IServiceCollection AddPersistence(this IServiceCollection Services)
    {
      Services.AddScoped<IUserRepository, UserRepository>();
      Services.AddScoped<IMenuRepository, MenuRepository>();
      return Services;
    }
    // ....
  }
}
```
### Command Validator
```csharp
namespace Donation.Application.Menus.Commands.CreateMenu
{
  public class CreateMenuCommandValidator : AbstractValidator<CreateMenuCommand>
  {
    public CreateMenuCommandValidator() {
      RuleFor(x => x.Name).NotEmpty();
      RuleFor(x => x.Description).NotEmpty();
      RuleFor(x => x.Sections).NotEmpty();
    }
  }
}
```
### Controller Action
```csharp
namespace Donation.Api.Controllers
{
  [Route("hosts/{hostId}/menus")]
  public class MenusController : ApiController
  {
    private readonly IMapper mapper;
    private readonly ISender mediator;
    public MenusController(IMapper mapper, ISender mediator)
    {
      this.mapper = mapper;
      this.mediator = mediator;
    }
    [HttpPost]
    public async Task<IActionResult> CreateMenu(CreateMenuRequest request, string hostId)
    {
      var command = mapper.Map<CreateMenuCommand>((request, hostId));
      var createMenuResult = await mediator.Send(command);
      return createMenuResult.Match(
        menu => Ok(mapper.Map<MenuResponse>(menu)),
        errors => Problem(errors)
      );
      // this Code is replacement for menu => CreatedAtAction(nameof(GetMenu), new {hostId, menu}),
    }

  }
}
```
