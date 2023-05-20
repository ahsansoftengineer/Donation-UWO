using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectName.API.Controllers.Base;
using ProjectName.Domain.Base;
using ProjectName.Domain.DTOs.MadaniBastaDTOz;
using ProjectName.Infra.Entity.MadaniBastaEntity;
using ProjectName.Infra.Repo;
using X.PagedList;

namespace ProjectName.API.Controllers.MadaniBastaz
{
  [Route("api/[controller]")]
  [ApiController]
  public class MadaniBastaSubCategoryController : BaseController<MadaniBastaSubCategoryController>
  {
    public MadaniBastaSubCategoryController(
      ILogger<MadaniBastaSubCategoryController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    { }

    [HttpGet]
    public async Task<IActionResult> Gets([FromQuery] PaginateRequestFilter<MadaniBastaSubCategory, MadaniBastaSubCategoryDtoSearch?> filter)
    {
      try
      {
        var list = await UnitOfWork.MadaniBastaSubCategorys.Gets(filter);
        var result = Mapper.Map<IPagedList<MadaniBastaSubCategory>, PaginateResponse<MadaniBastaSubCategoryDto>>(list);
        return Ok(result);
      }
      catch (Exception ex)
      {
        return CatchException(ex, nameof(Gets));
      }
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> Get(int id)
    {
      var single = await UnitOfWork.MadaniBastaSubCategorys.Get(
        q => q.Id == id
     //, new List<string> { "Org" }
     );
      var result = Mapper.Map<BaseDTOSingle<MadaniBastaSubCategoryDto>>(single);
      return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] MadaniBastaSubCategoryDtoCreate data)
    {
      if (!ModelState.IsValid) return CreateInvalid();
      try
      {
        var result = Mapper.Map<MadaniBastaSubCategory>(data);
        await UnitOfWork.MadaniBastaSubCategorys.Insert(result);
        await UnitOfWork.Save();
        return Ok(result);
      }
      catch (Exception ex)
      {
        return CatchException(ex, nameof(Create));
      }
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, [FromBody] MadaniBastaSubCategoryDtoCreate data)
    {
      if (!ModelState.IsValid || id < 1) return UpdateInvalid();
      try
      {
        var item = await UnitOfWork.MadaniBastaSubCategorys.Get(q => q.Id == id);

        if (item == null) return UpdateNull();

        var result = Mapper.Map(data, item);
        UnitOfWork.MadaniBastaSubCategorys.Update(item);
        await UnitOfWork.Save();
        return Ok(result);
      }
      catch (Exception ex)
      {
        return CatchException(ex, nameof(Update));
      }
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
      if (id < 1) return DeleteInvalid();

      var search = await UnitOfWork.MadaniBastaSubCategorys.Get(q => q.Id == id);
      if (search == null) return DeleteNull();

      try
      {
        await UnitOfWork.MadaniBastaSubCategorys.Delete(id);
        await UnitOfWork.Save();
      }
      catch (Exception ex)
      {
        return CatchException(ex, nameof(Delete));
      }
      return NoContent();
    }
  }
}
