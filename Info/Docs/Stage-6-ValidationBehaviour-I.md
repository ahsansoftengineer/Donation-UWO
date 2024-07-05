## Validation Behavior

### What is the purpose of Validation Behavior
- By using Validation Behaviors, you can ensure the quality and consistency of the data that is being entered into your application, which can improve the overall reliability and usability of your application.

### Definition is same as Validation

### The Purpose of the Video is FluentValidation
- dotnet add .\Donation.Application\ package FluentValidation
- dotnet add .\Donation.Application\ package FluentValidation.AspNetCore

### How to Use FluentValiation
1. Create a Validation Class
```c#
namespace Donation.Application.Authentication.Commands.Register
public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
{
  public RegisterCommandValidator() {
      
    RuleFor(x => x.FirstName).NotEmpty();
    RuleFor(x => x.LastName).NotEmpty();
    RuleFor(x => x.Email).NotEmpty();
    RuleFor(x => x.Password).NotEmpty();
  }
}
```
2. Validation Register Command Behavior
```c#
namespace Donation.Application.Common.Behaviours
public class ValidationRegisterCommandBehavior :
  IPipelineBehavior<RegisterCommand, ErrorOr<AuthenticationResult>>
{
  private readonly IValidator<RegisterCommand> validator;

  public ValidationRegisterCommandBehavior(IValidator<RegisterCommand> validator)
  {
    this.validator = validator;
  }
  public async Task<ErrorOr<AuthenticationResult>> Handle(
    RegisterCommand request,
    RequestHandlerDelegate<ErrorOr<AuthenticationResult>> next, 
    CancellationToken cancellationToken)
  {
    var valResult = await validator.ValidateAsync(request, cancellationToken);

    if (valResult.IsValid)
    {
      return await next();
    }

    var errors = valResult.Errors
      .ConvertAll(valFailure => Error.Validation(
          valFailure.PropertyName,
          valFailure.ErrorMessage
        ));

    return errors;
  }
}

```
3. Register Validator Behavior
```c#
namespace Donation.Application
{
  public static class DependencyInjection
  {
    public static IServiceCollection AddApplication(this IServiceCollection Services)
    {
      Services.AddMediatR(typeof(DependencyInjection).Assembly);

      // Adding Behavior with RegisterCommand, AuthenticationResult, ValidationRegisterCommandBehaviorz
      Services.AddScoped<
        IPipelineBehavior<RegisterCommand, ErrorOr<AuthenticationResult>>,
        ValidationRegisterCommandBehavior
      >();

      // Way 1 Adding RegisterCommand with RegisterCommandValidator without Reflection
      //Services.AddScoped<
      //  IValidator<RegisterCommand>, 
      //  RegisterCommandValidator
      //>();

      // Way 2 Adding RegisterCommand, RegisterCommandValidator with Reflection Required a Package FluentValidation.AspNetCore
      Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

      return Services;
    }
  }
}
```
