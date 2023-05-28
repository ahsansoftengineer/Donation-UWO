using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectName.API.Controllers.Base;
using ProjectName.Domain.DTOs.Hierarchy;
using ProjectName.Infra.Entity.Hierarchy;
using ProjectName.Infra.Repo;

namespace ProjectName.API.Controllers.Hierarchy
{
  [Route("api/[controller]")]
  [ApiController]
  public class SystemzController : BaseController<SystemzController, Systemz, SystemzDtoSearch, SystemzDto, SystemzDtoCreate>
  {
    public SystemzController(
      ILogger<SystemzController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    {
      Repo = unitOfWork.Systemzs;

    }
  }
}