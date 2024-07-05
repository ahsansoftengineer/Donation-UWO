### Contract Layer - Request & Response 
#### Request
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
#### Response
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
### Application Layer - Command & Command Handler
#### Command
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
#### Command Handler
```csharp
namespace Donation.Application.Menus.Commands.CreateMenu
{
  public class CreateMenuCommandHandler : IRequestHandler<CreateMenuCommand, ErrorOr<Menu>>
  {
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

      // 3. Return Menu
      return menu;
    }
  }
}
```
### Action Method (Endpoint)
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
      return Ok(request);
    }

  }
}
```