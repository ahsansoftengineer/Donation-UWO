using ProjectName.Domain.Base;

namespace ProjectName.Domain.DTOs.Regionz
{
  public class StateDtoCreate : BaseDtoCreate
  {
    public int CountryId { get; set; }
  }
  public class StateDto : BaseDtoFull
  {
    public int CountryId { get; set; }
    public BaseDtoRelation? Country { get; set; }
  }
  public class StateDtoSearch : BaseDtoSearchFull
  {
    public int? CountryId { get; set; }
  }
}
