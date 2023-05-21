using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectName.API.Controllers.Base;
using ProjectName.Domain.Base;
using ProjectName.Domain.Model.Hierarchy;
using ProjectName.Infra.Entity.Hierarchy;
using ProjectName.Infra.Repo;
using X.PagedList;

namespace ProjectName.API.Controllers.Hierarchy
{
  [Route("api/[controller]")]
  [ApiController]
  public class SUController : BaseController<SUController>
  {
    public SUController(
      ILogger<SUController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    { }

    [HttpGet]
    public async Task<IActionResult> Gets([FromQuery] PaginateRequestFilter<SU, SUDtoSearch?> filter)
    {
      try
      {
        var list = await UnitOfWork.SUs.Gets(filter);
        var result = Mapper.Map<IPagedList<SU>, PaginateResponse<SUDto>>(list);
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
      var single = await UnitOfWork.SUs.Get(
        q => q.Id == id //, new List<string> { "Org" }
     );
      var result = Mapper.Map<BaseDtoSingle<SUDto>>(single);
      return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] SUDtoCreate data)
    {
      if (!ModelState.IsValid) return CreateInvalid();
      try
      {
        var result = Mapper.Map<SU>(data);
        await UnitOfWork.SUs.Insert(result);
        await UnitOfWork.Save();
        return Ok(result);
      }
      catch (Exception ex)
      {
        return CatchException(ex, nameof(Create));
      }
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, [FromBody] SUDtoCreate data)
    {
      if (!ModelState.IsValid || id < 1) return UpdateInvalid();
      try
      {
        var item = await UnitOfWork.SUs.Get(q => q.Id == id);

        if (item == null) return UpdateNull();

        var result = Mapper.Map(data, item);
        UnitOfWork.SUs.Update(item);
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

      var search = await UnitOfWork.SUs.Get(q => q.Id == id);
      if (search == null) return DeleteNull();

      try
      {
        await UnitOfWork.SUs.Delete(id);
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
