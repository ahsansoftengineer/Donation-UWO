using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectName.API.Controllers.Base;
using ProjectName.Domain.Model.Hierarchy;
using ProjectName.Infra.Entity.Hierarchy;
using ProjectName.Infra.Repo;

namespace ProjectName.API.Controllers.Hierarchy
{
  [Route("api/[controller]")]
  [ApiController]
  public class BGController : BaseController<BGController>
  {
    public BGController(
      ILogger<BGController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    { }

    [HttpGet]
    public async Task<IActionResult> Gets()
    {
      try
      {
        var list = await UnitOfWork.BGs.GetAll();
        var result = Mapper.Map<IList<BGDTO>>(list);
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
      var single = await UnitOfWork.BGs.Get(
        q => q.Id == id //, new List<string> { "Org" }
     );
      var result = Mapper.Map<BGDTO>(single);
      return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] BGDTOCreate data)
    {
      if (!ModelState.IsValid) return CreateInvalid();
      try
      {
        var result = Mapper.Map<BG>(data);
        await UnitOfWork.BGs.Insert(result);
        await UnitOfWork.Save();
        return Ok(result);
      }
      catch (Exception ex)
      {
        return CatchException(ex, nameof(Create));
      }
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, [FromBody] BGDTOCreate data)
    {
      if (!ModelState.IsValid || id < 1) return UpdateInvalid();
      try
      {
        var item = await UnitOfWork.BGs.Get(q => q.Id == id);

        if (item == null) return UpdateNull();

        var result = Mapper.Map(data, item);
        UnitOfWork.BGs.Update(item);
        await UnitOfWork.Save();
        return NoContent();
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

      var search = await UnitOfWork.BGs.Get(q => q.Id == id);
      if (search == null) return DeleteNull();

      try
      {
        await UnitOfWork.BGs.Delete(id);
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
