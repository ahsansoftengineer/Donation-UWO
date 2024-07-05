## Interview Questions
| Heading | Defination |
|:-------:|------------|
| Language Support | C++, C#, F#, Visual Basic
| Value Types | These types are either allocated within the structure inline or are stored directly in the stack. This includes built-in value types (standard primitive types), types defined in source code, user-defined value types, enumerations, etc.
| Reference Type | These store value memory address references and are allocated on the heap. They may be any of the interface types, pointer types, or self-describing types. For example- class types and arrays like boxed value types, delegates, user-defined classes, etc.
| Middleware | A middleware is a component of an application pipeline that handles requests and responses.
| .Net Standard | The .NET standard is a set of APIs meant to establish unity in the .NET ecosystem. It does this by compiling the base class libraries for different frameworks/ platforms. In simple terms, it creates a single uniform layer and set of APIs which support the whole of the .NET ecosystem. |
| .Net Core CLI |  Part of .Net SDK toolset used for developing/ building, running, and publishing all applications.


23. What is unit testing?
- Unit testing is the process of breaking the program down into small bits of code at the functional level, called units. The units are then tested to ensure that they return the value one expects. An advantage of the unit testing framework is that automates the process and keeps testing the program as it is being built.

24. What are NuGet packages?
- NuGet packages are parts of the package management system for .NET which are essential to carry on any development on the platform. These packages contain libraries and other descriptive metadata and are managed by NuGet.
- In simpler terms, a NuGet package is a single zip file with a .nupkg extension. The file contains compiled codes, files related to the code, and descriptions. Developers can create and share these packages by publishing them to either private or public hosts. They can also use the packages available and add to projects on an as-needed basis.

25. What are Empty migrations?
- When you want to add migrations without making any changes in the model it might lead to the creation of code files with empty classes. These can be customized to perform operations not related to the core Entity Framework (EF) model.

30. What is a class library? Mention its types and methods.
- A class library is a compilation of pre-written code templates and classes which developers can refer to and use when developing an application. Any class library that is developed with .NET Core supports the .NET Standard Library. It can then be called onto by any platform which supports that .NET Standard Library.

31. What is the purpose of webHostBuilder()
- The webHostBuilder() as the name suggests is a factory used to create a web host for a web application. This function also configures the bits needed by the web host to run the application. It is a part of Microsoft.AspNet.Hosting namespace.

32. Why would you generate SQL scripts in .Net core?
- When you want to add migrations, you will have to deploy and apply them to the database to bring it to action. This is where you need to generate SQL scripts that ensure accuracy in the application of the migrations and consequent schema changes of the databases.

33. How do you decide when to use .NET Standard Class Library as against .NET Core Library
- When you use the .NET Standard library type you will reduce the .NET surface area and at the same time increase the number of apps that are compatible with your library.
- You should use the .NET Core library type when the motive is to increase the .NET API surface area. But remember this also limits the compatibility of the library to only .NET Core applications.

34. (IMPORTANT) Explain the difference between Task and Thread in .NET
- In simple terms, a task is something you want to get done, and a thread is a way to accomplish it. So in this sense, a thread is a part of the task.
- A thread represents the smallest unit of code processing at the OS level, with stacks and kernels. You can exercise a high degree of control over threads with Suspend() or Abort() or Resume() a thread. ThreadPool, as the name suggests is a wrapper comprising a pool of threads maintained in the runtime environment by CLR.
- A task in comparison is executed by a TaskScheduler and cannot create its own OS threads. A default scheduler runs on the ThreadPool and also lets you know when the task finishes and returns a result.

36. What is JIT and how many types of JIT compilations do you know?
There are two steps to the whole process- first where the source code is converted to IL by language-specific compilers, and the second is converting IL to machine instructions by JIT compilers. These are called JIT compilers because only the executed IL code fragments are compiled to machine instructions, that too at the runtime, or should we say just-in-time for execution.
- Pre-JIT Compilers
- Econo JIT Compilers
- Normal JIT Compilers

37. Explain the meaning of state management
In simple terms, state management refers to the technique or process of maintaining the state of a page or application till the time the user's session ends. In .NET, state management refers to the object that controls the state of an object steady through different processes. Some common approaches followed for this include- cookies, cache, temp data, query strings, etc.

42. Why is the Startup Class?
- The Startup class in .NET Core contains the Configure methods and Configure services. Of these, the former helps configure the request processing pipeline, and the latter helps configure the required services.