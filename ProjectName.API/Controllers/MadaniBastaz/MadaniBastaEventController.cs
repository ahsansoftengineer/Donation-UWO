using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectName.API.Controllers.Base;
using ProjectName.Domain.Base;
using ProjectName.Domain.Common;
using ProjectName.Domain.DTOs.MadaniBastaDTOz;
using ProjectName.Infra.Entity.MadaniBastaEntity;
using ProjectName.Infra.Repo;
using X.PagedList;

namespace ProjectName.API.Controllers.MadaniBastaz
{
  [Route("api/[controller]")]
  [ApiController]
  public class MadaniBastaEventController : BaseController<MadaniBastaEventController>
  {
    public MadaniBastaEventController(
      ILogger<MadaniBastaEventController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    { }

    [HttpGet]
    public async Task<IActionResult> Gets([FromQuery] PaginateRequestFilter<MadaniBastaEvent, CommonDtoSearch?> filter)
    {
      try
      {
        var list = await UnitOfWork.MadaniBastaEvents.Gets(filter);
        var result = Mapper.Map<IPagedList<MadaniBastaEvent>, PaginateResponse<CommonDto>>(list);
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
      var single = await UnitOfWork.MadaniBastaEvents.Get(
        q => q.Id == id
     //, new List<string> { "Org" }
     );
      var result = Mapper.Map<BaseDtoSingle<CommonDto>>(single);
      return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CommonDtoCreate data)
    {
      if (!ModelState.IsValid) return CreateInvalid();
      try
      {
        var result = Mapper.Map<MadaniBastaEvent>(data);
        await UnitOfWork.MadaniBastaEvents.Insert(result);
        await UnitOfWork.Save();
        return Ok(result);
      }
      catch (Exception ex)
      {
        return CatchException(ex, nameof(Create));
      }
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, [FromBody] CommonDtoCreate data)
    {
      if (!ModelState.IsValid || id < 1) return UpdateInvalid();
      try
      {
        var item = await UnitOfWork.MadaniBastaEvents.Get(q => q.Id == id);

        if (item == null) return UpdateNull();

        var result = Mapper.Map(data, item);
        UnitOfWork.MadaniBastaEvents.Update(item);
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

      var search = await UnitOfWork.MadaniBastaEvents.Get(q => q.Id == id);
      if (search == null) return DeleteNull();

      try
      {
        await UnitOfWork.MadaniBastaEvents.Delete(id);
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

