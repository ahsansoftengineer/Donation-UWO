## EF Core DB Context

### Persistence Ignorance
1. Persistence ignorance in software development refers to designing and implementing software components in a way that they are not aware of how their data is being persisted or stored in a database. This means that the software component does not have any dependencies on a specific data storage technology, such as a relational database or a NoSQL database. This approach allows for greater flexibility and maintainability of the software system as it becomes easier to change the underlying data storage technology without affecting the software components.

2. In the .NET framework, persistence ignorance can be achieved through the use of an object-relational mapping (ORM) tool, such as Entity Framework, which provides a layer of abstraction between the software components and the underlying database. The ORM tool maps the object-oriented data model to the relational database schema and handles the translation of data between the two models.

3. Using an ORM tool can help developers focus on the business logic of the software components and not worry about the details of how data is persisted. This approach can also help improve performance as the ORM tool can optimize the queries sent to the database based on the data access patterns of the application.

4. In summary, persistence ignorance is an important principle in software development that can be achieved in .NET through the use of an ORM tool. This approach can help improve the maintainability and flexibility of the software system while also improving performance.

### Aggregate VS Entity
1. In domain-driven design, an "entity" is an object that has a unique identity and a lifecycle that is managed by the domain model. An "aggregate" is a cluster of related objects that are treated as a single unit of consistency, meaning that the aggregate ensures that all its constituent objects are in a valid state when changes are made to it.

2. In the context of .NET, an entity is often implemented as a class that encapsulates data and behavior related to a specific concept in the domain. For example, in an e-commerce application, an "Order" entity might have properties such as order number, customer ID, order date, and total price, as well as methods for adding items to the order, calculating taxes and discounts, and placing the order.

3. An aggregate, on the other hand, is a more complex concept that typically involves multiple entities and/or value objects. The aggregate root is the entity that serves as the entry point for accessing the aggregate, and it is responsible for ensuring that all changes made to the aggregate are consistent and that its invariants are preserved. For example, in an e-commerce application, an "Order" aggregate might include the Order entity, as well as entities for LineItems, ShippingAddress, BillingAddress, and PaymentDetails.

4. In summary, entities and aggregates are both important concepts in domain-driven design, with entities representing individual objects and aggregates representing clusters of related objects. In .NET, entities are often implemented as classes, while aggregates are more complex structures that typically involve multiple entities and/or value objects, with the aggregate root serving as the entry point for accessing and modifying the aggregate.