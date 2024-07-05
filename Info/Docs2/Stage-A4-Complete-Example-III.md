### Menu Request Record
```csharp
namespace Donation.Contracts.Menus
{
  public record CreateMenuRequest(
    string hostId,
    string Name,
    string Description,
    List<MenuSection> Sections);
  
  public record MenuSection(
    string Name,
    string Description,
    List<MenuItem > Items);

  public record MenuItem(
    string Name, 
    string Description);
}
```
### Menu Response
```csharp
namespace Donation.Contracts.Menus
{
  public record MenuResponse(
    Guid Id,
    string Name,
    string Description,
    float? AverageRating,
    List<MenuSectionResponse> Sections,
    string HostId,
    List<string> DinnerIds,
    List<string> MenuReviewIds,
    DateTime CreatedDateTime,
    DateTime UpdatedDateTime);

  public record MenuSectionResponse(
    string Id,
    string Name,
    string Description,
    List<MenuItemResponse> Items);

  public record MenuItemResponse(
    string Id,
    string Name,
    string Description);
}
```
### Menu Create Command
```csharp
namespace Donation.Application.Menus.Commands.CreateMenu
{
  public record CreateMenuCommand(
    string HostId,
    string Name,
    string Description,
    List<MenuSectionCommand> Sections) : IRequest<ErrorOr<Menu>>;

  public record MenuSectionCommand(
    string Name,
    string Description,
    List<MenuItemCommand> Items);

  public record MenuItemCommand(
    string Name,
    string Description);
}
```
### Menu Create Command Validator
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
### Create Command Handler
```csharp
namespace Donation.Application.Menus.Commands.CreateMenu
{
  public class CreateMenuCommandHandler : IRequestHandler<CreateMenuCommand, ErrorOr<Menu>>
  {
    private readonly IMenuRepository _menuRepository;

    public CreateMenuCommandHandler(IMenuRepository menuRepository)
    {
      _menuRepository = menuRepository;
    }

    public async Task<ErrorOr<Menu>> Handle(CreateMenuCommand request, CancellationToken cancellationToken)
    {
      await Task.CompletedTask;
      // 1. Create Menu
      var menu = Menu.Create(
          hostId: HostId.CreateUnique(),//HostId.Create(request.HostId),
          name: request.Name,
          description: request.Description,
          sections: request.Sections.ConvertAll(sections => MenuSection.Create(
              name: sections.Name,
              description: sections.Description,
              items: sections.Items.ConvertAll(items => MenuItem.Create(
                  name: items.Name,
                  description: items.Description)))));
      // 2. Persist Menu
      _menuRepository.Add(menu);
      // 3. Return Menu
      return menu;
    }
  }
}
```
### Menu Mapping
```csharp
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

      // Configuration of Mapping MenuResponse to Menu (dest is Menu, src is MenuResponse)
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
    }
  }
}
```

### Migrations
```csharp
dotnet tool list --global
dotnet tool install --global dotnet-ef
Install-Package Microsoft.EntityFrameworkCore.Tools // Power Shell
// Incase you have exception of Version
dotnet tool update --global dotnet-ef --version 3.1.0
// PM Package Manager Console
Add-Migration NameOfMigration -Context DatabaseContextName
// When you have One DBContext and One Project
dotnet ef migrations add NameOfMigration 
// When you have two or more Projects
dotnet ef migrations add NameOfMigration -p Donation.Infrastructure -s Donation.Api
// When you have Two or More DB Context
dotnet ef migrations add NameOfMigration -p ProjectName.Infra -s ProjectName.Api --context DBCntxt
dotnet ef migrations add NameOfMigration --context DatabaseContextName
// docker pull mcr.microsoft.com/mssql/server:2022-latest
// docker image ls
// docker run -e 'HOMEBREW_NO_ENV_FILTERING=1' -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=asdf1234' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest
// docker ps
// PM Package Manager Console
UPDATE-DATABASE -Context DatabaseContext
dotnet ef database update -p Donation.Infrastructure -s Donation.Api --connection "SERVER=.;DATABASE=Donation;USER=sa;PASSWORD=asdf1234;Encrypt=false"
dotnet ef database update -p ProjectName.Infra -s ProjectName.Api --connection "SERVER=.;DATABASE=Test;USER=sa;PASSWORD=asdf1234;Encrypt=false"
dotnet run --project ProjectName.Api
```
