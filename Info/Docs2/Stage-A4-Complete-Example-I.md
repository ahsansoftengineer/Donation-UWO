### JSON
```json
{
  "id": { "value": "00000000-0000-0000-0000-000000000000" },
  "name": "Yummy Menu",
  "description": "A menu with yummy food",
  "averageRating": 4.5,
  "sections": [
    {
      "id": { "value": "00000000-0000-0000-0000-000000000000" },
      "name": "Appetizers",
      "description": "Starters",
      "items": [
        {
          "id": { "value": "00000000-0000-0000-0000-000000000000" },
          "name": "Fried Pickles",
          "description": "Deep fried pickles"
        }
      ]
    }
  ],
  "hostId": { "value": "00000000-0000-0000-0000-000000000000" },
  "dinnerIds": [
    { "value": "00000000-0000-0000-0000-000000000000" }
  ],
  "menuReviewIds": [
    { "value": "00000000-0000-0000-0000-000000000000" }
  ],
  "createdDateTime": "2020-01-01T00:00:00.0000000Z",
  "updatedDateTime": "2020-01-01T00:00:00.0000000Z"
}
```
### DB Table
```sql
SELECT TOP (1000) [Id]
      ,[Name]
      ,[Description]
      ,[AverageRating_Value]
      ,[AverageRating_NumRatings]
      ,[HostId]
      ,[CreatedDateTime]
      ,[UpdatedDateTime]
  FROM [Donation].[dbo].[Menus]
  
SELECT TOP (1000) [MenuSectionId]
      ,[MenuId]
      ,[Name]
      ,[Description]
  FROM [Donation].[dbo].[MenuSections]
  
SELECT TOP (1000) [MenuItemId]
      ,[MenuSectionId]
      ,[MenuId]
      ,[Name]
      ,[Description]
  FROM [Donation].[dbo].[MenuItems]
```

### ValueObjects
```csharp
namespace Donation.Domain.Common.Models
{
  public abstract class ValueObject
  {
    public abstract IEnumerable<object> GetEqualityComponents();
    public override bool Equals(object? obj)
    {
      if(obj is null || obj.GetType() != GetType()) return false;

      var valueObject = (ValueObject)obj;

      return GetEqualityComponents()
        .SequenceEqual(valueObject.GetEqualityComponents());
    }
    public static bool operator ==(ValueObject left, ValueObject right)
    {
      return Equals(left, right);
    }
    public static bool operator !=(ValueObject left, ValueObject right)
    {
      return !Equals(left, right);
    }
    public override int GetHashCode()
    {
      return GetEqualityComponents()
        .Select(x => x?.GetHashCode() ?? 0)
        .Aggregate((x, y) => x ^ y);
    }
    public bool Equals(ValueObject? other)
    {
      return Equals((object?)other);  
    }
  }
}
```
### MenuId
```csharp
namespace Donation.Domain.Menu.ValueObjects
{
  public sealed class MenuId : ValueObject
  {
    public Guid Value { get; }
    private MenuId(Guid value) 
    {
      Value = value;
    }
    public static MenuId CreateUnique()
    {
      return new (Guid.NewGuid());
    }
    public static MenuId Create(Guid value)
    {
      return new MenuId(value);
    }
    public override IEnumerable<object> GetEqualityComponents()
    {
      yield return Value;
    }
  }
}
```
### MenuSectionId
```csharp
 public sealed class MenuSectionId : ValueObject
  {
    public Guid Value { get; }
    private MenuSectionId(Guid value)
    {
      Value = value;
    }
    public static MenuSectionId CreateUnique()
    {
      return new(Guid.NewGuid());
    }
    public static MenuSectionId Create(Guid value)
    {
      return new MenuSectionId(value);
    }
    public override IEnumerable<object> GetEqualityComponents()
    {
      yield return Value;
    }
  }
```
### MenuItemId
```csharp
namespace Donation.Domain.Menu.ValueObjects
{
  public sealed class MenuItemId : ValueObject
  {
    public Guid Value { get; }
    private MenuItemId(Guid value) 
    {
      Value = value;
    }
    public static MenuItemId CreateUnique()
    {
      return new (Guid.NewGuid());
    }
    public static MenuItemId Create(Guid value)
    {
      return new MenuItemId(value);
    }
    public override IEnumerable<object> GetEqualityComponents()
    {
      yield return Value;
    }
  }
}
```
### DinnerIds Value Object
```csharp
namespace Donation.Domain.Dinner.ValueObjects
{
  public sealed class DinnerId : ValueObject
  {
    public Guid Value { get; }

    private DinnerId(Guid value)
    {
      Value = value;
    }
    public static DinnerId CreateUnique()
    {
      return new(Guid.NewGuid());
    }
    public static DinnerId Create(Guid value)
    {
      return new DinnerId(value);
    }
    public override IEnumerable<object> GetEqualityComponents()
    {
      yield return Value;
    }
  }
}
```
### MenuReviewIds Value Object
```csharp
namespace Donation.Domain.MenuReview.ValueObjects
{
  public sealed class MenuReviewId: ValueObject
  {
    public Guid Value { get; }

    private MenuReviewId(Guid value)
    {
      Value = value;
    }
    public static MenuReviewId CreateUnique()
    {
      return new(Guid.NewGuid());
    }
    public static MenuReviewId Create(Guid value)
    {
      return new MenuReviewId(value);
    }
    public override IEnumerable<object> GetEqualityComponents()
    {
      yield return Value;
    }
  }
}

```
### Value Object Rating
```csharp
namespace Donation.Domain.Common.ValueObjects
{
  public sealed class AverageRating : ValueObject
  {
    public double Value { get; private set; }
    public int NumRatings { get; private set; }

    private AverageRating(double value, int numRatings)
    {
      Value = value;
      NumRatings = numRatings;
    }
    public static AverageRating CreateNew(double rating = 0, int numRatings = 0)
    {
      return new AverageRating(rating, numRatings); 
    }
    public void AddNewRating(Rating rating)
    {
      Value = ((Value * NumRatings) + rating.Value) / (++NumRatings);
    }
    public override IEnumerable<object> GetEqualityComponents()
    {
      yield return Value;
    }
  }
}

```
### Entity
```csharp
namespace Donation.Domain.Common.Models
{
  public abstract class Entity<TId> : IEquatable<Entity<TId>>  where TId : notnull
  {
    public TId Id { get; protected set; }
    protected Entity(TId id)
    {
      Id = id;  
    }
    public override bool Equals(object? obj)
    {
      return obj is Entity<TId> entity && Equals((Entity<TId>)obj);
    }
    public static bool operator ==(Entity<TId> left, Entity<TId> right)
    {
      return Equals(left, right);
    }
    public static bool operator !=(Entity<TId> left, Entity<TId> right)
    {
      return !Equals(left, right);
    }
    public override int GetHashCode() 
    { 
      return Id.GetHashCode();
    }

    public bool Equals(Entity<TId>? other)
    {
      return Equals((object?)other);
    }
#pragma warning disable CS8618
    protected Entity() { }
#pragma warning restore CS8618

  }
```
### Aggregate Root
```csharp
namespace Donation.Domain.Common.Models
{
  public abstract class AggregateRoot<TId> : Entity<TId> where TId : notnull
  {
    protected AggregateRoot(TId id) : base(id) { }
#pragma warning disable CS8618
    protected AggregateRoot() { }
#pragma warning restore CS8618

  }
}
```
### MenuItem
```csharp
public sealed class MenuItem : Entity<MenuItemId>
{
  private readonly List<MenuItem> items = new();
  public string Name { get; }
  public string Description { get; }
  private MenuItem(
    MenuItemId menuItemId, 
    string name, 
    string description): base(menuItemId)
  {
    Name = name;
    Description = description;
  }
  public static MenuItem Create(
    string name,
    string description)
  {
    return new(MenuItemId.CreateUnique(), name, description);
  }
}
```
### MenuSection
```csharp
public sealed class MenuSection : Entity<MenuSectionId>
{
  private readonly List<MenuItem> items = new();
  public string Name { get; }
  public string Description { get; }
  IReadOnlyList<MenuItem> Items => items.AsReadOnly(); // AS per need .ToList();
  private MenuSection(
    MenuSectionId menuSectionId,
    string name, 
    string description): base(menuSectionId)
  {
    Name = name;
    Description = description;
  }
  public static MenuSection Create(
    string name,
    string description)
  {
    return new(
      MenuSectionId.CreateUnique(),
      name,
      description);
  }
}
```
### Menu
```csharp
namespace Donation.Domain.Menu
{
  public sealed class Menu : AggregateRoot<MenuId>
  {
    private readonly List<MenuSection> sections = new();
    private readonly List<DinnerId> dinners = new();
    private readonly List<MenuReviewId> menuReview = new();
    public string Name { get; }
    public string Description { get; }
    public AverageRating AverageRating { get;}
    public DateTime CreatedDateTime { get; }  
    public DateTime UpdatedDateTime { get; }

    public HostId HostId { get; }
    public IReadOnlyList<MenuSection> Sections => sections.AsReadOnly();
    public IReadOnlyList<DinnerId> DinnersIds => dinners.AsReadOnly();
    public IReadOnlyList<MenuReviewId> MenuReviewIds => menuReview.AsReadOnly();

    // Constructor
    private Menu(
      MenuId menuId,
      string name,
      string description, 
      HostId hostId,
      DateTime createdDateTime, 
      DateTime updatedDateTime) : base(menuId)
    {
      Name = name;
      Description = description;
      HostId = hostId;
      CreatedDateTime = createdDateTime;
      UpdatedDateTime = updatedDateTime;
    }
    // Factory Method
    public static Menu Create(
      string name,
      string description,
      HostId hostId)
    {
      return new(
        MenuId.CreateUnique(),
        name,
        description,
        hostId,
        DateTime.UtcNow,
        DateTime.UtcNow);
    }
  }
}
```
### Dinners (Only to See MenuId)
```csharp
namespace Donation.Domain.Dinner
{
  public sealed class Dinner : AggregateRoot<DinnerId>
  {
    public HostId HostId { get; } // <=
    public MenuId MenuId { get; } // <=
  }
}
```
