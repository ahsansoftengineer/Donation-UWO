### How to Work on AggregateRoot, Entity, ValueObjects?
1. MenuId
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
    public override IEnumerable<object> GetEqualityComponents()
    {
      yield return Value;
    }
  }
}
```
2. MenuItemId
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
    public override IEnumerable<object> GetEqualityComponents()
    {
      yield return Value;
    }
  }
}
```
3. MenuItem
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
4. MenuSectionId
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
    public override IEnumerable<object> GetEqualityComponents()
    {
      yield return Value;
    }
  }
```
5. MenuSection
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


```
2. Menu
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