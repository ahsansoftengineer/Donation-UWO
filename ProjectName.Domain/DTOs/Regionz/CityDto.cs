using ProjectName.Domain.Base;

namespace ProjectName.Domain.DTOs.Regionz
{
  public class CityDtoCreate : BaseDtoCreate
  {
    public int StateId { get; set; }
  }
  public class CityDto : BaseDtoFull
  {
    public int StateId { get; set; }
    public BaseDtoRelation? State { get; set; }
  }
  public class CityDtoSearch : BaseDtoSearchFull
  {
    public int? StateId { get; set; }
  }
}
