using ProjectName.Domain.Model.Base;

namespace ProjectName.Domain.Model.Hierarchy
{
  public class LEDTOCreate : BaseDTOCreate
  {
    public int BGId { get; set; }
  }

  public class LEDTO : BaseDTOFull
  {
    public int BGId { get; set; }
    public BaseDTORelation BG { get; set; }
  }
}
