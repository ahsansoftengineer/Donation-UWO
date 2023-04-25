using ProjectName.Domain.Model.Base;

namespace ProjectName.Domain.Model.Hierarchy
{
  public class SystemzDTOCreate : BaseDTOCreate
  {
    public int OrgId { get; set; }
  }

  public class SystemzDTO : BaseDTOFull
  {
    public int OrgId { get; set; }
    public BaseDTORelation Org { get; set; }
  }
}
