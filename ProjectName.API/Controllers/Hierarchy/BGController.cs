using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectName.API.Controllers.Base;
using ProjectName.Domain.Common;
using ProjectName.Infra.Entity.Hierarchy;
using ProjectName.Infra.Repo;

namespace ProjectName.API.Controllers.Hierarchy
{
  [Route("api/[controller]")]
  [ApiController]
  public class BGController : CharlieController<BGController, BG, CommonDtoSearch, CommonDto, CommonDtoCreate>
  {
    public BGController(
      ILogger<BGController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    {
      Repo = unitOfWork.BGs;
    
    }
  }
}
