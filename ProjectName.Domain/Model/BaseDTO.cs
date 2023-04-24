using System.ComponentModel.DataAnnotations;

namespace ProjectName.Domain.Model
{
  public class BaseDTOCreateFull : BaseDTOCreate
  {
    public int Id { get; set; }
    //public IList<Hotel> Hotels { get; set; }

  }
  public class BaseDTOUpdateFull : BaseDTOCreate
  {
    //public IList<CreateHotelDTO> Hotels { get; set; }
  }
  public class BaseDTOCreate
  {
    [Required]
    [StringLength(maximumLength: 50, ErrorMessage = "Country Name is Too Long")]
    public string Title { get; set; }
    [Required]
    [StringLength(maximumLength: 100, ErrorMessage = "Short Country Name is Too Long")]
    public string Description { get; set; }
    [Required]
    [StringLength(maximumLength: 100, ErrorMessage = "Short Country Name is Too Long")]
    public string CreatedAt { get; } = new DateTime().ToLongDateString();
    public string UpdatedAt { get; set; } = new DateTime().ToLongDateString();
  }
}
