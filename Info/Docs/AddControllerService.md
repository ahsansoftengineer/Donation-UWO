## Default Services Provided by AddController

### AddControllersCore(services)
```c#
  .AddMvcCore()
  .AddApiExplorer()
  .AddAuthorization()
  .AddCors()
  .AddDataAnnotations()
  .AddFormatterMappings();
```
#### AddMvcCoreServices(services);
```c#
  // It has several Other Services as we
  services.TryAddSingleton<IActionResultExecutor<RedirectToRouteResult>, RedirectToRouteResultExecutor>();
  services.TryAddSingleton<IActionResultExecutor<RedirectToPageResult>, RedirectToPageResultExecutor>();
  services.TryAddSingleton<IActionResultExecutor<ContentResult>, ContentResultExecutor>();
  services.TryAddSingleton<IActionResultExecutor<JsonResult>, SystemTextJsonResultExecutor>();
  services.TryAddSingleton<IClientErrorFactory, ProblemDetailsClientErrorFactory>();
```
#### Other Core Services
- Does not have that much of services
