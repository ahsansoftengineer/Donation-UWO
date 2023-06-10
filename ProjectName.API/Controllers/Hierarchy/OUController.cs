using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectName.API.Common;
using ProjectName.API.Controllers.Base;
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
      var result = Mapper.Map<OUDtoCreate, OUDtoCreateToEntity>(model);
      // Way 1
      IActionResult topImg = await FileUploderz.UploadFile(model.TopImg, "TopImage");
      //var topImg = await FileUploderz.UploadFile(model.TopImg, "TopImage"); //
      if (topImg is OkObjectResult topResult) result.TopImg = (string)topResult.Value;

      // Way 3 Reflection
      await FileUploderz.UploadFileReflection(model.LogoImg, "LogoImg", result);
      await FileUploderz.UploadFileReflection(model.WarningImg, "WarningImg", result);
      await FileUploderz.UploadFileReflection(model.FooterImg, "FooterImg", result);
      
      if (!ModelState.IsValid) return CreateInvalid();
      try
      {
        var finalResult = Mapper.Map<OUDtoCreateToEntity, OU>(result);
        await Repo.Insert(finalResult);
        await UnitOfWork.Save();
        return Ok(finalResult);
      }
      catch (Exception ex)
      {
        return CatchException(ex, nameof(Create));
      }
    }
  }
}