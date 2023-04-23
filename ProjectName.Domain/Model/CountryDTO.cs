using System.ComponentModel.DataAnnotations;

namespace ProjectName.Domain.Model
{
  public class CountryDTO : CreateCountryDTO
  {
    public int Id { get; set; }
    //public IList<Hotel> Hotels { get; set; }

  }
  public class UpdateCountryDTO : CreateCountryDTO
  {
    //public IList<CreateHotelDTO> Hotels { get; set; }
  }
  public class CreateCountryDTO
  {
    [Required]
    [StringLength(maximumLength: 50, ErrorMessage = "Country Name is Too Long")]
    public string Name { get; set; }
    [Required]
    [StringLength(maximumLength: 2, ErrorMessage = "Short Country Name is Too Long")]
    public string ShortName { get; set; }
  }
}
