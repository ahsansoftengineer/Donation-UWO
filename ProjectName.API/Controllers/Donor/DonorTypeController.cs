using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectName.API.Controllers.Base;
using ProjectName.Infra.Entity.Donor;
using ProjectName.Infra.Repo;

namespace ProjectName.API.Controllers.Donor
{
  [Route("api/[controller]")]
  [ApiController]
  public class DonorTypeController : CommonStatusController<DonorTypeController, DonorType>
  {
    public DonorTypeController(
      ILogger<DonorTypeController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    {
      Repo = unitOfWork.DonorTypes;
    }
  }
}