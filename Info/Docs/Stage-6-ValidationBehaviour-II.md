## Validation Behavior Generic

### This is Continued from Previous Branch
### Package 
- dotnet add .\Donation.Domain\ package ErrorOr

### To use Generic Validation
1. Validation Model
```c#
namespace Donation.Application.Authentication.Commands.Register;
public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
{
  public RegisterCommandValidator() {

    RuleFor(x => x.FirstName).NotEmpty().Length(1, 10);
    RuleFor(x => x.LastName).NotEmpty().MaximumLength(10);
    RuleFor(x => x.Email).NotEmpty().MinimumLength(5);
    RuleFor(x => x.Password).NotEmpty();
  }
}
```
2. Creating Generic Validation Behavior
```c#
namespace Donation.Application.Common.Behaviours;

public class ValidationBehavior<TRequest, TResponse> :
  IPipelineBehavior<TRequest, TResponse> 
    where TRequest : IRequest<TResponse>
    where TResponse : IErrorOr
{
  private readonly IValidator<TRequest>? validator;

  public ValidationBehavior(IValidator<TRequest>? validator = null)
  {
    this.validator = validator;
  }
  public async Task<TResponse> Handle(
    TRequest request,
    RequestHandlerDelegate<TResponse> next,
    CancellationToken cancellationToken
    )
  {
    if (validator is null) return await next();

    var valResult = await validator.ValidateAsync(request, cancellationToken);

    if (valResult.IsValid)  return await next();

    var errors = valResult.Errors
      .ConvertAll(
        valFailure => Error.Validation(
          valFailure.PropertyName,
          valFailure.ErrorMessage
        )
        );

    // Compiler Doesn't know there is implicit converter to ErrorOr Object
    // dynamic use runtime to check to convert list of object to ErrorOr Object
    return (dynamic)errors;
  }
}
```
3. Registering Validation Behavior to DI
```c#
namespace Donation.Application;
public static class DependencyInjection
{
  public static IServiceCollection AddApplication(this IServiceCollection Services)
  {
    Services.AddMediatR(typeof(DependencyInjection).Assembly);

    // Generic Adding Services
    Services.AddScoped(
      typeof(IPipelineBehavior<,>),
      typeof(ValidationBehavior<,>)
    );

    Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

    return Services;
  }
}
```
4. Changing Response Depending on Validation State
```c#
namespace Donation.Api.Controllers
[ApiController]
public class ApiController : ControllerBase
{
  protected IActionResult Problem(List<Error> errors)
  {
    if (errors.Count is 0)
    {
      return Problem();
    }

    if (errors.All(error => error.Type == ErrorType.Validation))
    {
      return ValidationProblemz(errors);
    }
    // If you Customize your Validation Code
    if (errors.All(error => error.NumericType == 23))
    {
      return ValidationProblemz(errors);
    }

    // HttpContext is accessible inside Controller
    HttpContext.Items[HttpContextItemKeys.Errors] = errors;

    var firstError = errors[0];

    return Problemz(firstError);
  }

  private IActionResult Problemz(Error error)
  {
    var statusCode = error.Type switch
    {
      ErrorType.Conflict => StatusCodes.Status409Conflict,
      ErrorType.Validation => StatusCodes.Status400BadRequest,
      ErrorType.NotFound => StatusCodes.Status404NotFound,
      _ => StatusCodes.Status500InternalServerError,
    };

    // Coming From ControllerBase
    return Problem(statusCode: statusCode, title: error.Description);
  }

  private IActionResult ValidationProblemz(List<Error> errors)
  {
    var modelStateDic = new ModelStateDictionary();

    foreach (var error in errors)
    {
      modelStateDic.AddModelError(
        error.Code,
        error.Description
      );
    }

    // Coming From ControllerBase
    return ValidationProblem(modelStateDic);
  }
}

```
### IMAGES
![Validation Behavior](https://github.com/ahsansoftengineer/donation-DDD/blob/6-ValidationBeheviorGeneric/Info/Images/Stage%206%20-%20Validation%20Behavior.png)
![Global Error Handling Draw Back](https://github.com/ahsansoftengineer/donation-DDD/blob/6-ValidationBeheviorGeneric/Info/Images/Stage%203-%20Global%20Error%20Handling%20Draw%20Back.png)
![Global Error Handling](https://github.com/ahsansoftengineer/donation-DDD/blob/6-ValidationBeheviorGeneric/Info/Images/Stage%203-%20Global%20Error%20Handling.png)