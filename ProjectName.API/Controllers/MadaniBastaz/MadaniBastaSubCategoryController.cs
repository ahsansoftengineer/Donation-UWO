using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectName.API.Controllers.Base;
using ProjectName.Domain.DTOs.MadaniBastaDTOz;
using ProjectName.Infra.Entity.MadaniBastaEntity;
using ProjectName.Infra.Repo;

namespace ProjectName.API.Controllers.MadaniBastaz
{
  [Route("api/[controller]")]
  [ApiController]
  public class MadaniBastaSubCategoryController : BaseController<MadaniBastaSubCategoryController, MadaniBastaSubCategory, MadaniBastaSubCategoryDtoSearch, MadaniBastaSubCategoryDto, MadaniBastaSubCategoryDtoCreate>
  {
    public MadaniBastaSubCategoryController(
      ILogger<MadaniBastaSubCategoryController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    {
      Repo = unitOfWork.MadaniBastaSubCategorys;

    }
  }
}