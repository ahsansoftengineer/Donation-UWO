### Types of Design Patterns
- There are three main categories of design patterns:
- These patterns provide proven solutions to common design problems, and can help developers write better, more maintainable code. It's important to note that while patterns can be helpful, they should be used judiciously and only when appropriate. Overuse of patterns can lead to unnecessary complexity and can make code harder to maintain.

#### 1. Creational Patterns: These patterns are concerned with the process of object creation. They provide solutions to various object creation problems, such as how to create objects in a flexible, reusable way or how to ensure that only one instance of an object is created.
| Heading | Defination |
|:-------:|:---------- | 
| Singleton | |
| Factory Method | |
| Abstract Factory | |
| Builder | |
| Prototype | |

#### 2. Structural Patterns: These patterns are concerned with the composition of classes and objects to form larger structures. They provide solutions to various structural problems, such as how to create object hierarchies or how to handle the relationships between objects.
| Heading | Defination |
|:-------:|:---------- | 
| Adapter | |
| Bridge | |
| Composite | |
| Decorator | |
| Facade | |
| Flyweight | |
| Proxy | |

#### 3. Behavioral Patterns: These patterns are concerned with the behavior and communication between objects. They provide solutions to various communication problems, such as how to pass messages between objects or how to encapsulate complex behavior.
| Heading | Defination |
|:-------:|:---------- | 
| Chain of Responsibility | |
| Command | |
| Interpreter | |
| Iterator | |
| Mediator | |
| Memento | |
| Observer | |
| State | |
| Strategy | |
| Template Method | |
| Visitor | |


### Design Patterns
| Heading | Defination |
|:-------:|:---------- | 
| Singleton, Doubleton, Tripleton | Singleton class ensures that there is only one instance of a particular class, a Doubleton class ensures that there are only two instances of a particular class, and a Tripleton class ensures that there are only three instances of a particular class. |
| Domain Driven Design | Overall, DDD helps create software systems that are better aligned with the business domain and are more flexible and maintainable over time. |
| Repository | In software engineering, a repository is a design pattern that provides an abstraction layer between the application and the database. It provides a set of methods to access and manipulate data in the database without exposing the underlying implementation details |
| Generic Repository | A generic repository is a generic implementation of a repository that provides a generic set of methods to work with any type of entity or data model. It uses a generic type parameter to allow the repository to work with any entity, without the need for specific implementations for each entity type. |
| Pub Sub | This pattern has several benefits. First, it promotes decoupling of components, as publishers and subscribers do not need to know about each other's existence. Second, it allows for scaling and distribution of components, as multiple subscribers can receive the same message. Third, it supports asynchronous communication, as messages can be sent and received independently of each other. |
| Factory | There are several variations of the Factory Pattern, including the Simple Factory, Factory Method, and Abstract Factory. Overall, the Factory Pattern provides a flexible and scalable way to create objects, and it can improve the maintainability and extensibility of the codebase. |
| Simple Factory | The Simple Factory provides a static method to create objects of a specific class based on the input parameters. |
| Factory Method | The Factory Method is a pattern that defines an interface for creating an object but allows subclasses to decide which class to instantiate. |
| Abstract Factory | The Abstract Factory pattern provides an interface for creating families of related or dependent objects, without specifying their concrete classes. |
| Observer | This pattern is useful in situations where there are multiple dependent objects that need to be notified of changes in a state. It can also improve the modularity and flexibility of the codebase, as the subject and observers are not tightly coupled to each other. |
| State Mgmt | 1. Props: passing data between parent and child components. 2. State: a JavaScript object that holds data for a component and can be updated using the setState method. 3. Redux: a state management library that provides a centralized store for all application state. 4. Context API: a feature in React that allows components to share data without the need for props or event handling. 5. Reactive programming: using reactive programming techniques to handle state changes in a reactive and efficient way. | 
| Decorator | The Decorator Pattern is useful in situations where there are many variations of a class, each with slightly different behavior, but where it is important to keep the class hierarchy flat and avoid creating a large number of subclasses. By using decorators to add behavior dynamically, it is possible to create many different variations of an object while keeping the original class hierarchy intact. |
| Adapter | The Adapter Pattern is a structural design pattern that allows two incompatible interfaces to work together by wrapping an object with a new interface. The Adapter Pattern allows objects with incompatible interfaces to work together, without modifying the source code of the objects. |
| Facade | Structural Design Pattern In the Facade Pattern, a facade is a class that provides a simplified interface to a complex system or set of subsystems. The facade wraps the complex system and provides a single entry point for the client, which simplifies the interaction between the client and the system. The facade can also handle the communication between the client and the system, shielding the client from the details of the system's internal workings. |
| Template Method | The Template Method Pattern is a behavioral design pattern that defines the outline of an algorithm in a method, allowing subclasses to provide their own implementation for certain steps of the algorithm. The Template Method Pattern provides a framework for defining the steps of an algorithm, while allowing individual steps to be customized by subclasses. |
| Prototype | 1. The Prototype Pattern is a creational design pattern that allows objects to be copied or cloned. The Prototype Pattern creates new objects by copying or cloning existing objects, rather than creating them from scratch. 2. In the Prototype Pattern, a prototype is an object that serves as a template for creating new objects. The prototype defines the structure and behavior of the object, and new objects can be created by copying or cloning the prototype. |


### Option Pattern 
- The .NET Core Options pattern is a way of configuring an application using classes and objects in the form of options. This pattern is commonly used to provide configuration settings to an application, which can be used to customize its behavior.
- *The Options pattern consists of the following components:*
1. Options class: This class is used to define the configuration settings required by the application. It should have properties with default values that can be overridden by configuration providers.
2. Configuration provider: This is used to provide configuration values to the application. It can be any source of configuration data, such as environment variables, JSON files, command-line arguments, or Azure Key Vault.
3. Configuration builder: This is used to build the configuration providers and define the order in which they should be applied.
4. Service registration: This is used to register the Options class with the dependency injection container, allowing it to be injected into the application's services.