## EF Core DB Context

### NuGet Packages
```csharp
dotnet add Donation.Infrastructure package Microsoft.EntityFrameworkCore 
dotnet add Donation.Infrastructure package Microsoft.EntityFrameworkCore.SqlServer
dotnet add Donation.Infrastructure package Microsoft.EntityFrameworkCore.Design
```
### Models
#### Base Entities
```csharp
namespace Donation.Domain.Common.Models
{
  public abstract class AggregateRoot<TId> : Entity<TId> where TId : notnull
  public abstract class Entity<TId> : IEquatable<Entity<TId>>
}
```
#### Ids / Value Object
```csharp
namespace Donation.Domain.Menu.ValueObjects
{
  public sealed class MenuId : ValueObject
  public sealed class MenuSectionId : ValueObject
  public sealed class MenuItemId : ValueObject
}
```
#### Creating Models
```csharp

namespace Donation.Domain.Menu
{
  public sealed class Menu : AggregateRoot<MenuId>
}
namespace Donation.Domain.Menu.Entities
{
  public sealed class MenuSection : Entity<MenuSectionId>
}
namespace Donation.Domain.Menu.Entities
{
  public sealed class MenuItem : Entity<MenuItemId>
}
```
### Repository
#### DB Context
```csharp
namespace Donation.Infrastructure.Persistence
{
  public class DonationDbContext : DbContext
}
```
#### Repository
```csharp
namespace Donation.Infrastructure.Persistence.Repositories
{
  public class MenuRepository : IMenuRepository
}
```
#### Configure Models to Tables
```csharp
namespace Donation.Infrastructure.Persistence.Configurations
{
  public class MenuConfigurations : IEntityTypeConfiguration<Menu>
}
```
#### Adding Dependencies
```csharp
namespace Donation.Infrastructure
{
  public static class DependencyInjection
}
```
#### Migration Generated Files
```csharp
namespace Donation.Infrastructure.Migrations
{
    [DbContext(typeof(DonationDbContext))]
    partial class DonationDbContextModelSnapshot : ModelSnapshot
}
namespace Donation.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
}
```
### Commands to work with EF Migration & Docker
#### .NET CLI Tools
- This Tool is useful for Migrations
```csharp
dotnet tool list --global
dotnet tool install --global dotnet-ef
Install-Package Microsoft.EntityFrameworkCore.Tools // Power Shell
dotnet ef migrations add InitialCreate -p Donation.Infrastructure -s Donation.Api
```

#### Docker 
```csharp
docker pull mcr.microsoft.com/mssql/server:2022-latest
docker image ls
docker run -e 'HOMEBREW_NO_ENV_FILTERING=1' -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=asdf1234' -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest
docker container ls
docker ps
dotnet ef database update -p Donation.Infrastructure -s Donation.Api --connection "Server=localhost;Database=Donation;User Id=sa;Password=asdf1234;Encrypt=false"
dotnet run --project Donation.Api
````

### Images
![EF Core](https://github.com/ahsansoftengineer/donation-DDD/blob/A2-EF-Core-DDD-CleanArchetecture/Info/Images/StageA2-EF-Core-DDD.png)
![EF Core](https://github.com/ahsansoftengineer/donation-DDD/blob/A2-EF-Core-DDD-CleanArchetecture/Info/Images/StageA2-EF-Core-DDD-I.png)
![EF Core](https://github.com/ahsansoftengineer/donation-DDD/blob/A2-EF-Core-DDD-CleanArchetecture/Info/Images/StageA2-EF-Core-Full-Diagram.png)
![EF Core](https://github.com/ahsansoftengineer/donation-DDD/blob/A2-EF-Core-DDD-CleanArchetecture/Info/Images/StageA2-EF-Core-Z-DB-Diagram.png)
![EF Core](https://github.com/ahsansoftengineer/donation-DDD/blob/A2-EF-Core-DDD-CleanArchetecture/Info/Images/StageA2-EF-Core-Z-DB-Diagram-II.png)
![EF Core](https://github.com/ahsansoftengineer/donation-DDD/blob/A2-EF-Core-DDD-CleanArchetecture/Info/Images/StageA2-EF-Core-Z-DB-Diagram-III.png)
![EF Core](https://github.com/ahsansoftengineer/donation-DDD/blob/A2-EF-Core-DDD-CleanArchetecture/Info/Images/StageA2-EF-Core-Z-DB-Diagram-IV.png)
![EF Core](https://github.com/ahsansoftengineer/donation-DDD/blob/A2-EF-Core-DDD-CleanArchetecture/Info/Images/StageA2-EF-Core-Z-DB-Diagram-V.png)
![EF Core](https://github.com/ahsansoftengineer/donation-DDD/blob/A2-EF-Core-DDD-CleanArchetecture/Info/Images/StageA2-EF-Core-Z-DB-Diagram-VI.png)
![EF Core](https://github.com/ahsansoftengineer/donation-DDD/blob/A2-EF-Core-DDD-CleanArchetecture/Info/Images/StageA2-EF-Core-Z-DB-Diagram-VII.png)
