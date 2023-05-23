using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectName.Infra.Repo;

namespace ProjectName.API.Controllers.Base
{
  [Route("api/[controller]")]
  [ApiController]
  public abstract class AlphaController<TController> : ControllerBase
  {
    protected ILogger<TController> Logger { get; }
    protected IMapper Mapper { get; }
    protected IUnitOfWork UnitOfWork { get; }
    public AlphaController(ILogger<TController> logger, IMapper mapper, IUnitOfWork unitOfWork)
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