using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectName.API.Controllers.Base;
using ProjectName.Domain.Base;
using ProjectName.Domain.Common;
using ProjectName.Infra.Entity.Hierarchy;
using ProjectName.Infra.UOW;
using X.PagedList;

namespace ProjectName.API.Controllers.Hierarchy
{
    [Route("api/[controller]")]
  [ApiController]
  public class OrgController : AlphaController<OrgController>
  {
    public OrgController(
      ILogger<OrgController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    { }

    // Without Pagination
    //[HttpGet]
    //public async Task<IActionResult> Gets(
    //  [FromQuery] string TitleLike = "Org", 
    //  [FromQuery] int IdLessThan = 10)
    //{
    //  try
    //  {
    //    var list = await UnitOfWork.Orgs.Gets(
    //      (org) => org.Title.StartsWith(TitleLike),
    //      (orgQuery) =>
    //      {
    //        return orgQuery
    //          .Where(org => org.Id < IdLessThan)
    //          .OrderBy(org => org.CreatedAt)
    //          .ThenBy(org => org.Title);
    //      }
    //      ,
    //      new List<string> { "Systemzs" } // Working but no Mapping with DTO
    //    );
    //    //var result = Mapper.Map<IList<OrgDto>>(list);
    //     var result = Mapper.Map<IList<OrgDtoWithSystemzs>>(list); //
    //    return Ok(result);
    //  }
    //  catch (Exception ex)
    //  {
    //    return CatchException(ex, nameof(Gets));
    //  }
    //}


    // API Caching 1. To Client know API Caching
    // [ResponseCache(Duration = 60)]
    // API Caching 4. Using Global Cache Profile
    // API Caching 8. Setting Applied Globally no need to apply here
    // [ResponseCache(CacheProfileName="120SecondsDuration")]
    // API Caching 9. With Marvin.Cache.Headers
    //[HttpCacheExpiration(CacheLocation = CacheLocation.Public, MaxAge = 60)]
    //[HttpCacheValidation(MustRevalidate = false)]
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Gets([FromQuery] PaginateRequestFilter<Org, CommonDtoSearch?> filter)
    {
      try
      {
        var list = await UnitOfWork.Orgs.Gets(filter);
        var result = Mapper.Map<IPagedList<Org>, PaginateResponse<CommonDto>>(list);
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
      var single = await UnitOfWork.Orgs.Get(
        q => q.Id == id
        // ,new List<string> { "Systemz" }
     );
      var result = Mapper.Map<BaseDtoSingle<CommonDto>>(single);
      //result.Systemz.Hotels = null; //
      return Ok(result);
    }

    //[Authorize(Roles = "Administrator")]
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Create([FromBody] CommonDtoCreate data)
    {
      if (!ModelState.IsValid) return CreateInvalid();
      try
      {

        //, new List<string> { "Country" }
        var result = Mapper.Map<Org>(data);
        await UnitOfWork.Orgs.Insert(result);
        await UnitOfWork.Save();
        return Ok(result);
        //return CreatedAtRoute("Get", new { id = result.Id }, result);
        //CreatedResult
        //CreatedAtAction
        //CreatedAtActionResult
        //CreatedAtRouteResult
      }
      catch (Exception ex)
      {
        return CatchException(ex, nameof(Create));
      }
    }

    [HttpPut("{id:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<IActionResult> Update(int id, [FromBody] CommonDtoCreate data)
    {
      if (!ModelState.IsValid || id < 1) return UpdateInvalid();
      try
      {
        var item = await UnitOfWork.Orgs.Get(q => q.Id == id);

        if (item == null) return UpdateNull();

        var result = Mapper.Map(data, item);
        UnitOfWork.Orgs.Update(item);
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

