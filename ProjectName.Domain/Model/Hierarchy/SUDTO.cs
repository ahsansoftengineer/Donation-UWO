using ProjectName.Domain.Model.Base;

namespace ProjectName.Domain.Model.Hierarchy
{
  public class SUDtoCreate : BaseDtoCreate
  {
    public int OUId { get; set; }
  }

  public class SUDto : BaseDtoFull
  {
    public int OUId { get; set; }
    public BaseDtoRelation? OU { get; set; }
  }
}
