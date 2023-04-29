using ProjectName.Domain.Model.Base;

namespace ProjectName.Domain.Model.Hierarchy
{
  public class OUDtoCreate : BaseDtoCreate
  {
    public int LEId { get; set; }
  }

  public class OUDto : BaseDtoFull
  {
    public int LEId { get; set; }
    public BaseDtoRelation? LE { get; set; }
  }
}
