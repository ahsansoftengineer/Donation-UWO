using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectName.API.Common;
using ProjectName.API.Controllers.Base;
using ProjectName.Domain.Common;
using ProjectName.Domain.DTOs.Hierarchy;
using ProjectName.Infra.Entity.Hierarchy;
using ProjectName.Infra.UOW;

namespace ProjectName.API.Controllers.Hierarchy
{
  [Route("api/[controller]")]
  [ApiController]
  public class OUController : BaseController<OUController, OU, OUDtoSearch, OUDto, OUDtoCreate>
  {
    public FileUploderz FileUploderz { get; }
    public OUController(
      ILogger<OUController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork,
      FileUploderz fileUploderz
      ) : base(logger, mapper, unitOfWork)
    {
      Repo = unitOfWork.OUs;
      FileUploderz = fileUploderz;
    }


    [HttpPost("create-ou")]
    public async Task<IActionResult> UploadFile([FromForm] OUDtoCreate model)
    {
      Console.WriteLine(model.TopImg);
      await FileUploderz.UploadFile(model.TopImg);
      return Ok();
    }
  }
}