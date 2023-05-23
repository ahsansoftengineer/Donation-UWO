using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectName.API.Controllers.Base;
using ProjectName.Domain.DTOs.Donation;
using ProjectName.Infra.Entity.Donationz;
using ProjectName.Infra.Repo;

namespace ProjectName.API.Controllers.Donation
{
  [Route("api/[controller]")]
  [ApiController]
  public class DonationSubTypeController : CharlieController<DonationSubTypeController, DonationSubType, DonationSubTypeDtoSearch, DonationSubTypeDto, DonationSubTypeDtoCreate>
  {
    public DonationSubTypeController(
      ILogger<DonationSubTypeController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    {
      Repo = unitOfWork.DonationSubTypes;

    }
  }
}