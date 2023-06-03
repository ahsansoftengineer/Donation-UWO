using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectName.API.Controllers.Base;
using ProjectName.API.Controllers.Hierarchy;
using ProjectName.Infra.Entity.Hierarchy;
using ProjectName.Infra.Entity.Regionz;
using ProjectName.Infra.UOW;

namespace ProjectName.API.Controllers.Regionz
{
    [Route("api/[controller]")]
  [ApiController]
  public class CountryController : CommonController<CountryController, Country>
  {
    public CountryController(
      ILogger<CountryController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    {
      Repo = unitOfWork.Countrys;

    }
  }
}
