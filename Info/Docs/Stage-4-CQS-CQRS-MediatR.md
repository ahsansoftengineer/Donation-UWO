## CQS CQRS & MediatR

### How does MediatR actually works
1. MediatR works like pipeline behavior

### CQS vs CQRS
1. CQS (Command Query Separation) and CQRS (Command Query Responsibility Segregation) are both software design patterns that aim to separate the responsibilities of data modification (commands) and data retrieval (queries).

2. CQS states that every method should either be a command that performs an action, or a query that returns data to the caller, but not both.

3. CQRS extends this idea and separates the responsibilities of data modification and data retrieval into separate objects (write side and read side) to allow for a more optimized data retrieval process. This can lead to better scalability and performance, especially in complex and large-scale systems.

### How to Manage Application by Folder Structures?
- There are two ways of Managing Application Horizontally, Vertically
- Your Folder Structure must not go beyond three levels

#### Way 1
- Vertically Means Every Feature has two Folders Commands and Query Features * 2
1. Donation.Application
- Services
- - Common
- - - AuthenticationResult
- - Authentication
- - - Command
- - - - AutehnticationCommandService
- - - - IAutehnticationCommandService
- - - Query
- - - - AutehnticationQueryService
- - - - IAutehnticationQueryService
- - Product, Command, Query ....

#### Way 2
- Vertically Means Every Command Has Single Feature Folder
2. Donation.Application
-  Services
- - Common
- - - AuthenticationResult
- - Command
- - - Authentication
- - - - AutehnticationCommandService
- - - - IAutehnticationCommandService
- - Query
- - - Authentication
- - - - AutehnticationQueryService
- - - - IAutehnticationQueryService


### Images
![CQS & CQRS](https://github.com/ahsansoftengineer/donation-DDD/blob/5-Mapster-ObjectMapping/Info/Images/Stage%204%20CQS%20CQRS%20MediatR.png)

![CQS & CQRS](https://github.com/ahsansoftengineer/donation-DDD/blob/5-Mapster-ObjectMapping/Info/Images/Stage%204%20CQS%20CQRS%20MediatR%20II.png)
