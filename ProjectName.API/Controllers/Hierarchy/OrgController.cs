﻿using AutoMapper;
using Marvin.Cache.Headers;
using Microsoft.AspNetCore.Mvc;
using ProjectName.API.Controllers.Base;
using ProjectName.Domain.Model.Base;
using ProjectName.Infra.Entity.Hierarchy;
using ProjectName.Infra.Repo;

namespace ProjectName.API.Controllers.Hierarchy
{
  [Route("api/[controller]")]
  [ApiController]
  public class OrgController : BaseController<OrgController>
  {
    public OrgController(
      ILogger<OrgController> logger,
      IMapper mapper,
      IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    { }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]

    // API Caching 1. To Client know API Caching
    // [ResponseCache(Duration = 60)]
    // API Caching 4. Using Global Cache Profile
    // API Caching 8. Setting Applied Globally no need to apply here
    // [ResponseCache(CacheProfileName="120SecondsDuration")]

    // API Caching 9. With Marvin.Cache.Headers
    //[HttpCacheExpiration(CacheLocation = CacheLocation.Public, MaxAge = 60)]
    //[HttpCacheValidation(MustRevalidate = false)]
    public async Task<IActionResult> Gets()
    {
      try
      {
        var list = await UnitOfWork.Orgs.GetAll();
        var result = Mapper.Map<IList<BaseDTOCreateFull>>(list);
        return Ok(result);
      }
      catch (Exception ex)
      {
        return CatchException(ex, nameof(Gets));
      }
    }
    [HttpGet("{id:int}", Name = "Get")]
    public async Task<IActionResult> Get(int id)
    {
      var single = await UnitOfWork.Orgs.Get(
        q => q.Id == id
        // ,new List<string> { "Systemz" }
     );
      var result = Mapper.Map<BaseDTOCreateFull>(single);
      //result.Systemz.Hotels = null; //
      return Ok(result);
    }

    //[Authorize(Roles = "Administrator")]
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> Create([FromBody] BaseDTOCreate data)
    {
      if (!ModelState.IsValid) return CreateInvalid();
      try
      {

        //, new List<string> { "Country" }
        var result = Mapper.Map<Org>(data);
        await UnitOfWork.Orgs.Insert(result);
        await UnitOfWork.Save();
        return CreatedAtRoute("Get", new { id = result.Id }, result);
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
    public async Task<IActionResult> Update(int id, [FromBody] BaseDTOCreate data)
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
