using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectName.API.Controllers.Base;
using ProjectName.Infra.Entity.MadaniBastaEntity;
using ProjectName.Infra.Repo;

namespace ProjectName.API.Controllers.MadaniBastaz
{
  [Route("api/[controller]")]
  [ApiController]
  public class MadaniBastaController : CommonController<MadaniBastaController, MadaniBasta>
  {
    public MadaniBastaController(
      ILogger<MadaniBastaController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    {
      Repo = unitOfWork.MadaniBastas;

    }
  }
}