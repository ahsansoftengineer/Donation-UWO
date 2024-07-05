### Request
```csharp
namespace Donation.Contracts.Simple
{
  public record SimpleRequestCreate(
    string Title,
    string Description);

  public record SimpleRequestChildCreate(
    Guid ParentId,
    string Title,
    string Description
  );
}
```
### Response
```csharp
namespace Donation.Contracts.Simple
{
  public record SimpleOption(
    string Title,
    string Description);
    
  public record SimpleResponseCreate(
    string Id,
    string Title,
    string Description);

  public record SimpleResponseChildCreate(
    string Id,
    string Title,
    string Description,
    string ParentId
    //,SimpleOption Parent
    );
}
```
### Command
```csharp
using ErrorOr;
using MediatR;

namespace Donation.Application.Simple
{
  public record SimpleCommandCreate<TEntity>(
    string Title,
    string Description) : IRequest<ErrorOr<TEntity>>;

  public record SimpleCommandChildCreate<TEntity>(
    Guid ParentId,
    string Title,
    string Description) : IRequest<ErrorOr<TEntity>>;
}
```
### Command Validator
```csharp
using FluentValidation;

namespace Donation.Application.Simple
{
  public class SimpleCommandValidatorCreate<TEntity>: AbstractValidator<SimpleCommandCreate<TEntity>>
  {
    public SimpleCommandValidatorCreate()
    {
      RuleFor(x => x.Title).NotEmpty();
      RuleFor(x => x.Title).Length(3, 20);

      RuleFor(x => x.Description).NotEmpty();
      RuleFor(x => x.Description).Length(0, 100);
    }
  }

  public class SimpleCommandValidatorChildCreate<TEntity> : AbstractValidator<SimpleCommandChildCreate<TEntity>>
  {
    public SimpleCommandValidatorChildCreate()
    {
      RuleFor(x => x.Title).NotEmpty();
      RuleFor(x => x.Title).Length(3, 20);

      RuleFor(x => x.Description).NotEmpty();
      RuleFor(x => x.Description).Length(0, 100);

      RuleFor(x => x.ParentId).NotEmpty();
    }
  }
}
```
### Validator Extending
```csharp
using Donation.Application.Simple;
using Donation.Domain.HierarchyAggregate;

namespace Donation.Application.Hierarchy.Commands
{
  public class CreateOrgCommandValidator : SimpleCommandValidatorCreate<Org> { }
  public class CreateSystemzCommandValidator : SimpleCommandValidatorChildCreate<Systemz> { }
}
```
### Command Handler

```csharp
namespace Donation.Application.Hierarchy.Commands
{
  public class CreateOrgCommandHandler : IRequestHandler<SimpleCommandCreate<Org>, ErrorOr<Org>>
  {
    private readonly IOrgRepo Repo;

    public CreateOrgCommandHandler(IOrgRepo repo)
    {
      Repo = repo;
    }
    // For Parent
    public async Task<ErrorOr<Org>> Handle(SimpleCommandCreate<Org> request, CancellationToken cancellationToken)
    {
      await Task.CompletedTask;
      var item = Org.Create(
          title: request.Title,
          description: request.Description) ;
      Repo.Add(item);
      return item;
    }
    
    // For Child
    public async Task<ErrorOr<Systemz>> Handle(SimpleCommandChildCreate<Systemz> request, CancellationToken cancellationToken)
    {
      await Task.CompletedTask;
      var item = Systemz.Create(
          parentId: SimpleValueObject.Create(request.ParentId),
          title: request.Title,
          description: request.Description);
      Repo.Add(item);
      return item;
    }
  }
}
```
### Mapping 
```csharp
namespace Donation.Api.Common.Mapping.Hierarchy
{
  public class OrgMappingConfig : IRegister
  {
    public void Register(TypeAdapterConfig config)
    {
      // Parent
      config.NewConfig<SimpleRequestCreate, SimpleCommandCreate<Org>>()
        .Map(dest => dest, src => src);

      config.NewConfig<Org, SimpleResponseCreate>()
        .Map(dest => dest.Id, src => src.Id.Value);
      // Child
      config.NewConfig<SimpleRequestChildCreate, SimpleCommandChildCreate<Systemz>>()
        .Map(dest => dest, src => src);

      config.NewConfig<Systemz, SimpleResponseChildCreate>()
        .Map(dest => dest.Id, src => src.Id.Value)
        .Map(dest => dest.ParentId, src => src.OrgId.Value);
    }
  }
}
```
### Controller
```csharp
namespace Donation.Api.Controllers
{
  [Route("hierarchy/[controller]")]
  public class OrgController : ApiController
  {
    private readonly IMapper mapper;
    private readonly ISender mediator;
    public OrgController(IMapper mapper, ISender mediator)
    {
      this.mapper = mapper;
      this.mediator = mediator;
    }
    // For Parent Controller
    [HttpPost]
    public async Task<IActionResult> Create(SimpleRequestCreate request)
    {
      var command = mapper.Map<SimpleCommandCreate<Org>>(request);
      var createResult = await mediator.Send(command);
      return createResult.Match(
        entity => Ok(mapper.Map<SimpleResponseCreate>(entity)),
        errors => Problem(errors)
      );
    }
    // For Child Controller
    [HttpPost()]
    public async Task<IActionResult> Create(SimpleRequestChildCreate request)
    {
      var command = mapper.Map<SimpleCommandChildCreate<Systemz>>(request);
      var createResult = await mediator.Send(command);
      return createResult.Match(
        entity => Ok(mapper.Map<SimpleResponseChildCreate>(entity)),
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
dotnet ef migrations add InitialCreate -p Donation.Infrastructure -s Donation.Api
// When you are in Project
dotnet ef migrations add InitialCreate
// docker pull mcr.microsoft.com/mssql/server:2022-latest
// docker image ls
// docker run -e 'HOMEBREW_NO_ENV_FILTERING=1' -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=asdf1234' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest
// docker ps
dotnet ef database update -p Donation.Infrastructure -s Donation.Api --connection "SERVER=.;DATABASE=Donation;USER=sa;PASSWORD=asdf1234;Encrypt=false"
// When you are in project
dotnet ef database update --connection "SERVER=.;DATABASE=Donation;USER=sa;PASSWORD=asdf1234;Encrypt=false"
dotnet run --project Donation.Api
```
### SSMS CREADENTIALS
- SERVER TYPE : Database Engine
- SERVER NAME : 127.0.0.1,1433
- AUTHENTICATION : SQL Server Authentication
- LOGIN : sa
- PASSWORD : asdf1234
