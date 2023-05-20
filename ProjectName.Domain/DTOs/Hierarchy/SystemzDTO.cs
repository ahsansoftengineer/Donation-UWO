using ProjectName.Domain.Base;

namespace ProjectName.Domain.Model.Hierarchy
{
  public class SystemzDto : BaseDtoFull
  {
    public int OrgId { get; set; }
    public BaseDtoRelation? Org { get; set; }
  }
  public class SystemzDtoCreate : BaseDtoCreate
  {
    public int OrgId { get; set; }
  }
  public class SystemzDtoSearch : BaseDtoSearchFull
  {
    public int? OrgId { get; set; }
  }
}
