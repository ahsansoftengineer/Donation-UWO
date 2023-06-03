using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectName.API.Controllers.Base;
using ProjectName.Domain.DTOs.Donation;
using ProjectName.Infra.Entity.Donationz;
using ProjectName.Infra.UOW;

namespace ProjectName.API.Controllers.Donation
{
    [Route("api/[controller]")]
  [ApiController]
  public class TargetAssignmentController : BaseController<TargetAssignmentController, TargetAssignment, TargetAssignmenteDtoSearch, TargetAssignmentDto, TargetAssignmenteDtoSearch>
  {
    public TargetAssignmentController(
      ILogger<TargetAssignmentController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    {
      Repo = unitOfWork.TargetAssignments;

    }
  }
}