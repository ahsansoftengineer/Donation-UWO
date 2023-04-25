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
  public class SystemzController : BaseController<SystemzController>
  {
    public SystemzController(
      ILogger<SystemzController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    { }

    [HttpGet]
    public async Task<IActionResult> Gets()
    {
      try
      {
        var list = await UnitOfWork.Systemzs.GetAll();
        var result = Mapper.Map<IList<SystemzDTO>>(list);
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
      var single = await UnitOfWork.Systemzs.Get(
        q => q.Id == id, new List<string> { "Org" }
     );
      //single.Org.Systemzs = null;
      var result = Mapper.Map<SystemzDTO>(single);
      return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] SystemzDTOCreate data)
    {
      if (!ModelState.IsValid) return CreateInvalid();
      try
      {
        var result = Mapper.Map<Systemz>(data);
        await UnitOfWork.Systemzs.Insert(result);
        await UnitOfWork.Save();
        return CreatedAtRoute("Get", new { id = result.Id }, result);
      }
      catch (Exception ex)
      {
        return CatchException(ex, nameof(Create));
      }
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, [FromBody] SystemzDTOCreate data)
    {
      if (!ModelState.IsValid || id < 1) return UpdateInvalid();
      try
      {
        var item = await UnitOfWork.Systemzs.Get(q => q.Id == id);

        if (item == null) return UpdateNull();

        var result = Mapper.Map(data, item);
        UnitOfWork.Systemzs.Update(item);
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

      var search = await UnitOfWork.Orgs.Get(q => q.Id == id);
      if (search == null) return DeleteNull();

      try
      {
        await UnitOfWork.Orgs.Delete(id);
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
