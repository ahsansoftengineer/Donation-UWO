using ProjectName.Domain.Base;
using System.Runtime.InteropServices;

namespace ProjectName.Domain.Model.Hierarchy
{
  public class SystemzDtoCreate : BaseDtoCreate
  {
    public int OrgId { get; set; }
  }

  public class SystemzDto : BaseDtoFull
  {
    public int OrgId { get; set; }
    public BaseDtoRelation? Org { get; set; }
  }

  public class SystemzDtoSearch : BaseDtoSearchFull
  {
    public int? OrgId { get; set; }
  }
}
