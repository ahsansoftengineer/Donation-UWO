using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectName.API.Controllers.Base;
using ProjectName.Infra.Entity.MadaniBastaEntity;
using ProjectName.Infra.UOW;

namespace ProjectName.API.Controllers.MadaniBastaz
{
    [Route("api/[controller]")]
  [ApiController]
  public class MadaniBastaEventController : CommonController<MadaniBastaEventController, MadaniBastaEvent>
  {
    public MadaniBastaEventController(
      ILogger<MadaniBastaEventController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    {
      Repo = unitOfWork.MadaniBastaEvents;

    }
  }
}