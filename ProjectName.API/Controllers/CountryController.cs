using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectName.Domain.Model;
using ProjectName.Infra.Entity;
using ProjectName.Infra.Repo;

namespace ProjectName.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CountryController : ControllerBase
  {
    public IUnitOfWork UnitOfWork { get; }
    public ILogger<CountryController> Logger { get; }
    public IMapper Mapper { get; }

    public CountryController(
      IUnitOfWork unitOfWork,
      ILogger<CountryController> logger,
      IMapper mapper)
    {
      UnitOfWork = unitOfWork;
      Logger = logger;
      Mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> Gets()
    {
      var countries = await UnitOfWork.Countries.GetAll();
      var result = Mapper.Map<IList<CountryDTO>>(countries);
      return Ok(result);
    }
    [HttpGet("GetPagging")]
    public async Task<IActionResult> GetPagging(
      [FromQuery] RequestParams query)
    {
      var countries = await UnitOfWork.Countries.GetPagedList(query);
      var result = Mapper.Map<IList<CountryDTO>>(countries);
      return Ok(result);
    }
    [HttpGet("{id:int}")]
    public async Task<IActionResult> Get(int id)
    {
      var country = await UnitOfWork.Countries.Get(q => q.Id == id);
      var result = Mapper.Map<CountryDTO>(country);
      return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateCountryDTO data)
    {
      if (!ModelState.IsValid)
      {
        Logger.LogError($"Invalid POST attempt in {nameof(Create)}");
        return BadRequest(ModelState);
      }
      var result = Mapper.Map<Country>(data);
      await UnitOfWork.Countries.Insert(result);
      await UnitOfWork.Save();
      return CreatedAtRoute("Get", new { id = result.Id }, result);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Update(int id, [FromBody] UpdateCountryDTO data)
    {
      if (!ModelState.IsValid || id < 1)
      {
        Logger.LogError($"Invalid UPDATE attempt in {nameof(Update)}");
        return BadRequest(ModelState);
      }
      var search = await UnitOfWork.Countries.Get(q => q.Id == id);
      if (search == null)
      {
        Logger.LogError($"Invalid UPDATE attempt in {nameof(Update)}");
        return BadRequest("Submit Data is Invalid");
      }

      Mapper.Map(data, search);
      UnitOfWork.Countries.Update(search);
      await UnitOfWork.Save();
      return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
      if (id < 1)
      {
        Logger.LogError($"Invalid DELETE attempt in {nameof(Delete)}");
        return BadRequest();
      }
      var search = await UnitOfWork.Countries.Get(q => q.Id == id);
      if (search == null)
      {
        Logger.LogError($"Invalid DELETE attempt in {nameof(Delete)}");
        return BadRequest("Submit id is Invalid");
      }

      await UnitOfWork.Countries.Delete(id);
      await UnitOfWork.Save();

      return NoContent();
    }
  }
}
