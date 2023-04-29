using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectName.Domain.Model;
using ProjectName.Infra.Entity;

namespace ProjectName.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AccountController : ControllerBase
  {
    private UserManager<ApiUser> UserManager { get; }
    //private SignInManager<ApiUser> SignInManager { get; } //
    private ILogger<AccountController> Logger { get; }
    private IMapper Mapper { get; }
    public AccountController(
      UserManager<ApiUser> userManager,
      //SignInManager<ApiUser> signInManager,
      ILogger<AccountController> logger,
      IMapper mapper
      )
    {
      UserManager = userManager;
      //SignInManager = signInManager; //
      Logger = logger;
      Mapper = mapper;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] UserDto data)
    {
      Logger.LogInformation($"Registration Attempt for {data.Email}");

      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }
      var user = Mapper.Map<ApiUser>(data);
      user.UserName = data.Email;
      var result = await UserManager.CreateAsync(user, data.Password);

      if (!result.Succeeded)
      {
        foreach (var error in result.Errors)
        {
          ModelState.AddModelError(error.Code, error.Description);
        }

        return BadRequest("User Registration Attempt Failed");
      }
      await UserManager.AddToRolesAsync(user, data.Roles);
      return Accepted();
    }

    //[HttpPost("login")]
    //public async Task<IActionResult> Login([FromBody] LoginDto data)
    //{
    //  Logger.LogInformation($"Login Attempt for {data.Email}");
    //  if (!ModelState.IsValid)
    //  {
    //    return BadRequest(ModelState);
    //  }
    //  try
    //  {
    //    var result = await SignInManager.PasswordSignInAsync(
    //      data.Email,
    //      data.Password,
    //      false, // isPersistence (Mobile App, Browser etc..)
    //      false // Do you want to lock the user
    //      );

    //    if (!result.Succeeded)
    //    {
    //      return Unauthorized(data);
    //    }
    //    return Accepted();
    //  }
    //  catch (Exception ex)
    //  {
    //    string message = $"Something Went Wrong in the {nameof(Register)}";
    //    Logger.LogError(ex, message);
    //    return Problem(message, statusCode: 500);
    //  }
    //}

  }
}
