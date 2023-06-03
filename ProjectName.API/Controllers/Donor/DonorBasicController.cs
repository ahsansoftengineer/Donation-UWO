using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectName.API.Controllers.Base;
using ProjectName.Domain.DTOs.Donor;
using ProjectName.Infra.Entity.Donor;
using ProjectName.Infra.UOW;

namespace ProjectName.API.Controllers.Donor
{
    [Route("api/[controller]")]
  [ApiController]
  public class DonorBasicController : BaseController<
    DonorBasicController, DonorBasic, DonorBasicDtoSearch, DonorBasicDto, DonorBasicDtoCreate>
  {
    public DonorBasicController(
      ILogger<DonorBasicController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    {
      Repo = unitOfWork.DonorBasics;
    }
  }
}