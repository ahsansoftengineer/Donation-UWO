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
  public class CityController : BaseController<CityController, City, CityDtoSearch, CityDto, CityDtoCreate>
  {
    public CityController(
      ILogger<CityController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    {
      Repo = unitOfWork.Citys;

    }
  }
}