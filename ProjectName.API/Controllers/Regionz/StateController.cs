using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectName.API.Controllers.Base;
using ProjectName.Domain.DTOs.Regionz;
using ProjectName.Infra.Entity.Regionz;
using ProjectName.Infra.UOW;

namespace ProjectName.API.Controllers.Regionz
{
    [Route("api/[controller]")]
  [ApiController]
  public class StateController : BaseController<StateController, State, StateDtoSearch, StateDto, StateDtoCreate>
  {
    public StateController(
      ILogger<StateController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    {
      Repo = unitOfWork.States;

    }
  }
}