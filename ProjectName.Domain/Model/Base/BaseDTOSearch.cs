﻿
namespace ProjectName.Domain.Model.Base
{
  public class BaseDtoSearchFull
  {
    public int? Id { get; set; } = null;
    public string? Title { get; set; }
    public string? Description { get; set; }
    public DateTime? DateFrom { get; set; }
    public DateTime? DateTo { get; set; }
  }
}
