## Stage 3

### Global Error Handling
- Note : To Handle Error we have to remove Swagger and Developer Exception Middleware
```c#
    //app.UseDeveloperExceptionPage();
    //app.UseSwagger();
    //app.UseSwaggerUI();
```
1. Via Middleware
2. Via Exception Filter Attribute
3. Problem Details
4. Via Error Endpoint
5. Custom Problem Details Factory

### Middleware Exception
- After Creating Middleware add it into Program.cs
```c#
app.UseMiddleware<ErrorHandlingMiddleware>();
```

### Exception Filter
- After Creating Exception Filter add it into Program.cs
```c#
builder.Services.AddControllers(options =>
{
    options.Filters.Add<ErrorHandlingFilterAttribute>();
});
```

### Exception Controller
- After Creating Exception Controller and Endpoints then Add this into Program.cs
```c#
app.UseExceptionHandler("/error");
```

### DefaultProblemDetailsFactory
- It is continued with Exception Controller
- After Creating your own Class DonationOverrideDefaultProblemDetailsFactory
- This File is copy of DefaultProblemDetailsFactory 
```c#
// The Slight Changes in this file
// Here we are adding a Property when for Error
problemDetails.Extensions.Add("customeProperty", "Custom Value"); // <=

_configure?.Invoke(new() { HttpContext = httpContext!, ProblemDetails = problemDetails });

// Result of this Change
//{
//    "type": "https://tools.ietf.org/html/rfc7231#section-6.5.1",
//    "title": "User with given email already exists",
//    "status": 400,
//    "traceId": "00-cae291986b7f2b7f9dca05d8eb904584-ed76646d75ac46fb-00",
//    "customeProperty": "Custom Value" // <= To Achieve this in result set
//}
```

### Minimal API Exception Handling
```c#
 // 4.Minimal Api Approach this is not usefull
 app.Map("/error", (HttpContext context) =>
 {
   var code = HttpStatusCode.InternalServerError; // 500 if unexpected
   var result = JsonSerializer.Serialize(new
   {

     error = "Minimal API Processing Exception : " + "Any Message of my Choice",
     //error = ex.Message
   });

   context.Response.ContentType = "application/json";
   context.Response.StatusCode = (int)code;
   return context.Response.WriteAsync(result);
 });
```

### Flow Control and Fluent Result
1. .NET Core FluentResult is a library for creating type-safe, fluent and composable results for .NET Core applications. 
2. It provides a simple and intuitive way to return and handle errors, exceptions and results from method calls. 
3. The library is inspired by functional programming and makes it easy to create, compose and chain results, making it ideal for use in complex and error-prone applications. 

```c#
dotnet add .\Donation.Application\ package FluentResult
```

```c#
// 1. Interface Impl
namespace Donation.Application.Servicies.Authentication.IAuthenticationService
namespace Donation.Application.Servicies.Authentication.AuthenticationService

// 2. Impl IError for Custom Exception
namespace Donation.Application.Common.Errors.DuplicationEmailError : IError

// 3. Controller Action Method
[HttpPost("register")]
public IActionResult Register(RegisterRequest request)
{
  Result<AuthenticationResult> registerResult = authenticationSvc.Register(
    request.FirstName,
    request.LastName,
    request.Email,
    request.Password
  );

  if(registerResult.IsSuccess)
  {
    return Ok(MapAuthResult(registerResult.Value));
  }
  var firstError = registerResult.Errors[0];

  if(firstError is DuplicationEmailError) 
  {
    return Problem(
      statusCode: StatusCodes.Status409Conflict,
      detail: "Fluent : AuthController : Email already exists"

      );
  }
  return Problem();
}
```

### Flow Control | ErrorOr Library by Amantinband  
- ErrorOr has the ability to Handle both the way (OneOf, FluentResult)
- It can Categorize the Error
- Handle Single & List of Errors
- Manage Error by Error Code

- It has several Flexibility read the [Error Or](https://github.com/amantinband/error-or)

### Project Layers, Folders and Files Involvement
#### Donation.Api
- Common > 
- - Errors > DonationOverrideDefaultProblem
- - Http > HttpContextItemKeys
- Controllers
- - ApiController
- - ErrorsController
- - AuthenticationController
- Program.cs
#### Donation.Domain
- Common
- - Errors > Errors.Authentication.cs, Errors.User.cs

