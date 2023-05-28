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
  public class OUController : BaseController<OUController, OU, OUDtoSearch, OUDto, OUDtoCreate>
  {
    public OUController(
      ILogger<OUController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    {
      Repo = unitOfWork.OUs;

    }
  }
}