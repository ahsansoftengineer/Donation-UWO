
### [Value Object Microsoft Article](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/implement-value-objects)
### Aggregate Root Entities in DDD
1. In Domain-Driven Design (DDD), an Aggregate Root is an entity that serves as the primary access point to a group of related objects, known as an aggregate. The Aggregate Root is responsible for ensuring the consistency and integrity of the aggregate as a whole.

2. The Aggregate Root is the only entity within the aggregate that is accessible from outside the aggregate. Clients of the aggregate interact with the Aggregate Root to access and modify the state of the aggregate. The Aggregate Root encapsulates the internal state of the aggregate and enforces the invariants that govern the relationships between the objects within the aggregate.

3. One important principle of the Aggregate Root is that it should have exclusive access to the objects within the aggregate. This means that all changes to the state of the aggregate must go through the Aggregate Root, and no other object should be able to directly access or modify the state of the objects within the aggregate.

4. By using Aggregate Roots in DDD, you can create a model that is more expressive, encapsulated, and maintainable. Aggregates and Aggregate Roots are important building blocks for designing and implementing domain models that are closely aligned with the business problem being solved.

### What is ValueObject in DDD
1. In Domain-Driven Design (DDD), a Value Object is a type of object that represents a concept or idea within the domain that does not have an identity or a lifecycle of its own. A Value Object is defined solely by its attributes and does not need to have a unique identifier.

2. Value Objects are immutable and can be used to represent any concept that is not a standalone entity, such as a color, a date, a geographical location, a quantity, or a currency. Since Value Objects have no identity, they can be shared between entities and aggregates, and can be compared based on the equality of their attributes.

3. One important aspect of Value Objects is that they should be defined based on the characteristics that are important within the domain context. For example, a person's name and date of birth could be considered as separate Value Objects within a human resources domain, while in a social media domain, a user's name and profile picture could be considered as part of a single Value Object representing the user's profile.

4. Value Objects can help to improve the expressiveness, robustness, and maintainability of a domain model by providing a way to represent and reason about concepts that are important within the domain. They can also help to reduce the complexity of entities and aggregates by encapsulating domain logic within self-contained objects that can be reused across different parts of the domain model.

### Entity VS Value Object VS Aggregate
1. Entity is Immutable 
2. ValueObject is Immutable
3. ValueObject doesn't has the Id at its own
4. Entity Consider as Same when theirs Ids are same
5. Value Object's treated as same when their Property Values are same
6. Aggregate are composed of Several Entities and ValueObjects
7. Aggregate are treated as Transactional Boundaries when you modified it, should effect the whole SubEntities and ValueObjects

