using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ProjectName.Infra.Entity
{
  public class ApiUser : IdentityUser
  {
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    [DataType(DataType.PhoneNumber)]
    public override string? PhoneNumber { get; set; }

    public List<IdentityRole>? Roles { get; set; }
  }
}
