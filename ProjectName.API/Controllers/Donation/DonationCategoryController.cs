using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectName.API.Controllers.Base;
using ProjectName.Infra.Entity.Donationz;
using ProjectName.Infra.Repo;

namespace ProjectName.API.Controllers.Donation
{
  [Route("api/[controller]")]
  [ApiController]
  public class DonationCategoryController : CommonController<DonationCategoryController, DonationCategory>
  {
    public DonationCategoryController(
      ILogger<DonationCategoryController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    {
      Repo = unitOfWork.DonationCategorys;

    }
  }
}