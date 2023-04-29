﻿using System.ComponentModel.DataAnnotations;

namespace ProjectName.Domain.Model.Base
{
  public class BaseDtoCreate
  {
    [Required]
    [StringLength(maximumLength: 50, ErrorMessage = "Title is Too Long")]
    public string Title { get; set; } = "";
    [StringLength(maximumLength: 100, ErrorMessage = "Description is Too Long")]
    public string Description { get; set; } = "";

  }
  public class BaseDtoFull : BaseDtoCreate
  {
    public int Id { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    //public IList<Hotel> Hotels { get; set; } //

  }
  public class BaseDtoRelation
  {
    public int Id { get; set; }
    public string Title { get; set; } = "";
  }
  public class BaseDtoUpdateFull : BaseDtoCreate
  {
    //public IList<CreateHotelDTO> Hotels { get; set; } //
  }

}
