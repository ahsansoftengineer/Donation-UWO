using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ProjectName.Infra.Repo;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ProjectName.API.Controllers.Base
{
  public class BaseController<T> : ControllerBase
  {
    protected ILogger<T> Logger { get; }
    protected IMapper Mapper { get; }
    protected IUnitOfWork UnitOfWork { get; }
    public BaseController(ILogger<T> logger, IMapper mapper, IUnitOfWork unitOfWork)
    {
      Logger = logger;
      Mapper = mapper;
      UnitOfWork = unitOfWork;
    }

    protected ObjectResult CatchException(Exception ex, string methodName)
    {
      Logger.LogError(ex, $"Something went wrong in the {methodName}");
      return StatusCode(500, "Internal Server Error, Please try again later");
    }

    protected ObjectResult CreateInvalid()
    {
      Logger.LogError($"Invalid POST attempt in Create");
      return BadRequest(ModelState);
    }
    protected ObjectResult UpdateInvalid()
    {
      Logger.LogError($"Invalid UPDATE attempt in Update");
      return BadRequest(ModelState);
    }
    protected ObjectResult UpdateNull()
    {
      Logger.LogError($"Invalid UPDATE attempt in Update");
      return BadRequest("Submit Data is Invalid");
    }

    protected ObjectResult DeleteInvalid()
    {
      Logger.LogError($"Invalid DELETE attempt in Delete");
      return BadRequest("Submit id is Negative");
    }
    protected ObjectResult DeleteNull()
    {
      Logger.LogError($"Invalid DELETE attempt in Delete");
      return BadRequest("Submit id is Invalid");

    }
  }
}
