using ProjectName.Domain.Model.Base;

namespace ProjectName.Domain.Model.Hierarchy
{
  public class LEDtoCreate : BaseDtoCreate
  {
    public int BGId { get; set; }
  }

  public class LEDto : BaseDtoFull
  {
    public int BGId { get; set; }
    public BaseDtoRelation? BG { get; set; }
  }
}
