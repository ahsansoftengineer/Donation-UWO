//using Microsoft.AspNetCore.Mvc;
//using ProjectName.Infra.Context;

//namespace ProjectName.API.Controllers
//{
//  [ApiVersion("2.0", Deprecated = true)]
//  // 1. This Approach Uses Url for Configure Version
//  // [Route("api/{v:apiversion}/country")]
//  //curl -H "accept: */*" https://localhost:7061/api/2.0/country

//  // 2. This Approach uses Request Headers for Api Version
//  [Route("api/country")]
//  // curl -H "accept: */*" -H "api-supported-versions: 2.0" https://localhost:7061/api/country
//  [ApiController]
//  public class CountryV2Controller : ControllerBase
//  {
//    public DBCntxt Context { get; }

//    public CountryV2Controller(DBCntxt context)
//    {
//      Context = context;
//    }

//    [HttpGet]
//    public async Task<IActionResult> Gets()
//    {
//      return Ok(); //Context.Countries
//    }
//  }
//}
