//using AutoMapper;
//using Marvin.Cache.Headers;
//using Microsoft.AspNetCore.Mvc;
//using ProjectName.Infra.Repo;

//namespace ProjectName.API.Controllers
//{
//  [Route("api/[controller]")]
//  [ApiController]
//  public class HotelController : ControllerBase
//  {
//    private ILogger<HotelController> Logger { get; }
//    private IMapper Mapper { get; }
//    private IUnitOfWork UnitOfWork { get; }
//    public HotelController(ILogger<HotelController> logger, IMapper mapper, IUnitOfWork unitOfWork)
//    {
//      Logger = logger;
//      Mapper = mapper;
//      UnitOfWork = unitOfWork;
//    }

//    [HttpGet]
//    [ProducesResponseType(StatusCodes.Status200OK)]
//    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
//    // API Caching 1. To Client know API Caching
//    //[ResponseCache(Duration = 60)]
//    // API Caching 4. Using Global Cache Profile
//    // API Caching 8. Setting Applied Globally no need to apply here
//    //[ResponseCache(CacheProfileName="120SecondsDuration")]

//    // API Caching 9. With Marvin.Cache.Headers
//    [HttpCacheExpiration(CacheLocation = CacheLocation.Public, MaxAge = 60)]
//    [HttpCacheValidation(MustRevalidate = false)]
//    public async Task<IActionResult> Gets()
//    {
//      try
//      {
//        var hotels = await UnitOfWork.Hotels.Gets();
//        var result = Mapper.Map<IList<HotelDTO>>(hotels);
//        return Ok(result);
//      }
//      catch (Exception ex)
//      {
//        Logger.LogError(ex, $"Something went wrong in the {nameof(Gets)}");
//        return StatusCode(500, "Internal Server Error, Please try again later");
//      }
//    }
//    [HttpGet("{id:int}", Name = "Get")]
//    public async Task<IActionResult> Get(int id)
//    {
//      var hotel = await UnitOfWork.Hotels.Get(q => q.Id == id, new List<string> { "Country" });
//      var result = Mapper.Map<HotelDTO>(hotel);
//      result.Country.Hotels = null;
//      return Ok(result);
//    }

//    //[Authorize(Roles = "Adminstrator")]
//    [HttpPost]
//    [ProducesResponseType(StatusCodes.Status400BadRequest)]
//    [ProducesResponseType(StatusCodes.Status201Created)]
//    public async Task<IActionResult> Create([FromBody] CreateHotelDTO data)
//    {
//      if (!ModelState.IsValid)
//      {
//        Logger.LogError($"Invalid POST attempt in {nameof(Create)}");
//        return BadRequest(ModelState);
//      }
//      try
//      {
//        //, new List<string> { "Country" }
//        var result = Mapper.Map<Hotel>(data);
//        await UnitOfWork.Hotels.Insert(result);
//        await UnitOfWork.Save();
//        return CreatedAtRoute("Get", new { id = result.Id }, result);
//        //CreatedResult
//        //CreatedAtAction
//        //CreatedAtActionResult
//        //CreatedAtRouteResult
//      }
//      catch (Exception ex)
//      {
//        Logger.LogError(ex, $"Something went wrong in the {nameof(Create)}");
//        return StatusCode(500, "Internal Server Error, Please try again later");
//      }
//    }

//    [HttpPut("{id:int}")]
//    [ProducesResponseType(StatusCodes.Status204NoContent)]
//    public async Task<IActionResult> Update(int id, [FromBody] CreateHotelDTO data)
//    {
//      if (!ModelState.IsValid || id < 1)
//      {
//        Logger.LogError($"Invalid UPDATE attempt in {nameof(Update)}");
//        return BadRequest(ModelState);
//      }
//      try
//      {
//        var hotel = await UnitOfWork.Hotels.Get(q => q.Id == id);
//        if (hotel == null)
//        {
//          Logger.LogError($"Invalid UPDATE attempt in {nameof(Update)}");
//          return BadRequest("Submit Data is Invalid");
//        }

//        Mapper.Map(data, hotel);
//        UnitOfWork.Hotels.Update(hotel);
//        await UnitOfWork.Save();
//        return NoContent();
//      }
//      catch (Exception ex)
//      {
//        Logger.LogError(ex, $"Something went wrong in the {nameof(Update)}");
//        return StatusCode(500, "Internal Server Error, Please try again later");
//      }
//    }

//    [HttpDelete("{id:int}")]
//    public async Task<IActionResult> Delete(int id)
//    {
//      if (id < 1)
//      {
//        Logger.LogError($"Invalid DELETE attempt in {nameof(Delete)}");
//        return BadRequest();
//      }
//      var search = await UnitOfWork.Hotels.Get(q => q.Id == id);
//      if (search == null)
//      {
//        Logger.LogError($"Invalid DELETE attempt in {nameof(Delete)}");
//        return BadRequest("Submit id is Invalid");
//      }

//      await UnitOfWork.Hotels.Delete(id);
//      await UnitOfWork.Save();

//      return NoContent();
//    }
//  }
//}
