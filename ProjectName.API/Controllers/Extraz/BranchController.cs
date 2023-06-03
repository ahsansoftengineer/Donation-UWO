using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectName.API.Controllers.Base;
using ProjectName.Infra.Entity.Extraz;
using ProjectName.Infra.UOW;

namespace ProjectName.API.Controllers.Extraz
{
  [Route("api/[controller]")]
  [ApiController]
  public class BranchController : CommonController<BranchController, Branch>
  {
    public BranchController(
      ILogger<BranchController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    {
      Repo = unitOfWork.Branchs;

    }
  }
}
