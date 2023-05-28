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
  public class DonationCellMasterController : BaseController<DonationCellMasterController, DonationCellMaster, DonationCellMasterDtoSearch, DonationCellMasterDto, DonationCellMasterDtoCreate>
  {
    public DonationCellMasterController(
      ILogger<DonationCellMasterController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    {
      Repo = unitOfWork.DonationCellMasters;

    }
  }
}