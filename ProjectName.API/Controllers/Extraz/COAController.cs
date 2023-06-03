using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectName.API.Controllers.Base;
using ProjectName.Infra.Entity.Extraz;
using ProjectName.Infra.UOW;

namespace ProjectName.API.Controllers.Extraz
{
  [Route("api/[controller]")]
  [ApiController]
  public class COAController : CommonController<COAController, COA>
  {
    public COAController(
      ILogger<COAController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    {
      Repo = unitOfWork.COAs;

    }
  }
}