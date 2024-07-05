### How to Learn DDD
Learning Domain-Driven Design (DDD) can be a challenging task, but there are a few steps you can take to make the process easier:
1. Start with the basics: Begin by learning the key concepts of DDD, such as domain, bounded context, aggregates, and entities. You can start with reading books such as "Domain-Driven Design: Tackling Complexity in the Heart of Software" by Eric Evans or "Implementing Domain-Driven Design" by Vaughn Vernon.
2. Practice with examples: After you understand the key concepts, it's essential to practice them with real-world examples. You can look for sample projects or build one of your own.
3. Attend conferences and meetups: Attending conferences and meetups can help you learn from experts and network with other DDD enthusiasts.
4. Collaborate with others: Collaborating with other developers who are also learning DDD can be beneficial. You can share your knowledge, ask questions, and get feedback.
5. Use DDD tools: There are several tools available that can help you implement DDD, such as CQRS, Event Sourcing, and Repository Pattern. Use these tools to learn how DDD can be applied to real-world projects.
6. Keep learning: DDD is an ongoing process, and there is always something new to learn. Stay updated with the latest trends and advancements in DDD by reading blogs, attending webinars, and listening to podcasts.

### Clean Architecture, DDD, Onion Archetecture
<table>
  <thead>
    <tr>
      <th>Layer</th>
      <th>Internal Libraries</th>
      <th>External Libraries</th>
      <th>Purpose</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>Domain</td>
      <td>-</td>
      <td>ErrorOr</td>
      <td>Entities, Models, ValueObjects, Aggregate, AggregateRoot</td>
    </tr>
    <tr>
      <td>Contract</td>
      <td>-</td>
      <td>-</td>
      <td>Request, Response, Query, Commands, CommandHandlers</td>
    </tr>
     <tr>
      <td>Application</td>
      <td>Domain</td>
      <td>
        FluentValidation, FluentValidation.AspNetCore, MediatR, MediatR.Extensions.Microsoft.DependencyInjection, Microsoft.Extensions.DependencyInjection.Abstractions
      </td>
      <td>CommandHandler, QueryHandler, CommandValidator, ValidationBehavior</td>
    </tr>
     <tr>
      <td>Infrastructure</td>
      <td>Application</td>
      <td>
        Microsoft.EntityFrameworkCore, Microsoft.EntityFrameworkCore.SqlServer, Microsoft.Extensions.Configuration, Microsoft.Extensions.Options.ConfigurationExtensions, Microsoft.AspNetCore.Authentication.JwtBearer, System.IdentityModel.Tokens.Jwt
      </td>
      <td>DbContext, Repository, Migration, Configuration, JWT</td>
    </tr>
     <tr>
      <td>Presentation / API</td>
      <td>Contract, Application, Infrastructure</td>
      <td>
        Mapster, Mapster.DependencyInjection, Microsoft.AspNetCore.OpenApi, Microsoft.EntityFrameworkCore.Design, Swashbuckle.AspNetCore
      </td>
      <td> Controller, MappingConfiguration CQRS</td>
    </tr>
     <tr>
      <td>Trevior</td>
      <td>-</td>
      <td>ErrorOr</td>
      <td></td>
    </tr>
     <tr>
      <td>Domain</td>
      <td>-</td>
      <td colspan="2">
        AspNetCoreRateLimit, AutoMapper, AutoMapper.Extensions.Microsoft.DependencyInjection, Marvin.Cache.Headers, Microsoft.AspNetCore.Authentication.JwtBearer, Microsoft.AspNetCore.Authentication.OpenIdConnect, Microsoft.AspNetCore.Identity.EntityFrameworkCore, Microsoft.AspNetCore.Mvc.NewtonsoftJson, Microsoft.AspNetCore.Mvc.Versioning, Microsoft.EntityFrameworkCore, Microsoft.EntityFrameworkCore.SqlServer, Microsoft.EntityFrameworkCore.Tools, Serilog.AspNetCore, Swashbuckle.AspNetCore, "X.PagedList.Mvc.Core
      </td>
    </tr>
    <tr>
    <td>Core</td>
    <td colspan="3"> This is the innermost layer that contains the application's business logic, domain models, and interfaces for accessing external resources.</td>
    </tr>
  </tbody>
</table>

### DDD
| Heading | Defination |
|:-------:|:---------- | 
| Model-View-Controller (MVC) | MVC is often used in web applications, where the model represents the database or other data source, the view represents the HTML pages and UI elements, and the controller represents the server-side logic that handles requests and updates the view and model accordingly. |
| Model-View-View-Model (MVVM) | One of the key differences between MVVM and MVC is that MVVM uses data binding to connect the view and the ViewModel, rather than having the controller update the view directly. This allows for more flexibility and modularity in the design of the user interface, and can make it easier to write and test code. |
| ASP .NET Core Web Form () | Web Forms relies heavily on postbacks and view state to maintain the state of the application, which can make it more difficult to build scalable and maintainable applications. |
| Templating Engine | The basic idea behind a templating engine is to separate the content and the structure of a document from the logic that generates it. This allows developers to create templates that can be used to generate many different documents, without having to rewrite the content or the structure each time. |
