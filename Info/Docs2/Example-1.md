## DDD Simplified
### JSON
```json
// Parent
{
  "id": { 
    "value": "00000000-0000-0000-0000-000000000000" 
  },
  "title": "Org 1",
  "description": "Desc 1"
}
// Child
{
  "id": { 
    "value": "00000000-0000-0000-0000-000000000000" 
  },
  "title": "Systemz 1",
  "description": "Systemz 1"
  "parentId": { 
    "value": "00000000-0000-0000-0000-000000000000" 
  },
}
```
### DB Table 
```sql
SELECT TOP (1000) [Id]
      ,[Title]
      ,[Description]
      ,[CreatedAt]
      ,[UpdatedAt]
  FROM [Donation].[dbo].[Orgs]

SELECT TOP (1000) [Id]
      ,[OrgId]
      ,[Title]
      ,[Description]
      ,[CreatedAt]
      ,[UpdatedAt]
  FROM [Donation].[dbo].[Systemzs]
```
### Value Objects
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
### SimpleValueObjects
```csharp
using Donation.Domain.Common.Models;

namespace Donation.Domain.SimpleAggregates
{
  public sealed class SimpleValueObject : ValueObject
  {
    public Guid Value { get; }

    private SimpleValueObject(Guid value) 
    {
      Value = value;
    }
    public static SimpleValueObject CreateUnique()
    {
      return new (Guid.NewGuid());
    }
    public static SimpleValueObject Create(Guid value)
    {
      return new SimpleValueObject(value);
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
### SimpleAggregate
```csharp
using Donation.Domain.Common.Models;

namespace Donation.Domain.SimpleAggregates
{
  public class SimpleAggregate : AggregateRoot<SimpleValueObject>
  {
    public string Title { get; private set; }
    public string Description { get; private set; }

    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }

    public SimpleAggregate(
        SimpleValueObject id,
        string title,
        string description)
        : base(id)
    {
      Title = title;
      Description = description;
    }

    public static SimpleAggregate Create(
        string title,
        string description)
    {
      return new(
          SimpleValueObject.CreateUnique(),
          title,
          description);
    }

    // Private Constructor is Required for EF Core
#pragma warning disable CS8618
    protected SimpleAggregate() { }
#pragma warning restore CS8618
  }
}
```
### Parent Aggregate
```csharp
using Donation.Domain.SimpleAggregates;

namespace Donation.Domain.HierarchyAggregate
{
  public sealed class Org : SimpleAggregate
  {
    private readonly List<Systemz> systemz = new();
    public IReadOnlyList<Systemz> Systemz => systemz.AsReadOnly();

    protected Org(
    SimpleValueObject id,
    string title,
    string description)
    : base(id, title, description)
    {
    }

    public static Org Create(
        string title,
        string description)
    {
      return new(
          SimpleValueObject.CreateUnique(),
          title,
          description);
    }

#pragma warning disable CS8618
    private Org() { }
#pragma warning restore CS8618
  }
}
```
### Child Aggregate
```csharp
using Donation.Domain.SimpleAggregates;

namespace Donation.Domain.HierarchyAggregate
{
  public sealed class Systemz : SimpleAggregate
  {
    public SimpleValueObject OrgId { get; private set; }

    private Systemz(
        SimpleValueObject id,
        SimpleValueObject parentId,
        string title,
        string description)
        : base(id, title, description)
    {
      OrgId = parentId;
    }

    public static Systemz Create(
        SimpleValueObject parentId,
        string title,
        string description)
    {
      return new(
          SimpleValueObject.CreateUnique(),
          parentId,
          title,
          description);
    }

    // Private Constructor is Required for EF Core
#pragma warning disable CS8618
    private Systemz() { }
#pragma warning restore CS8618
  }
}
```

