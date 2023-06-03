using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectName.Domain.Common;
using ProjectName.Infra.Entity.Base;
using ProjectName.Infra.UOW;

namespace ProjectName.API.Controllers.Base
{
    [Route("api/[controller]")]
  [ApiController]
  public class CommonController<TController, TEntity> : BaseController<TController, TEntity, CommonDtoSearch, CommonDto, CommonDtoCreate>
    where TController : class
    where TEntity : BaseEntity
  {
    public CommonController(
      ILogger<TController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    { 

    }
  }
}