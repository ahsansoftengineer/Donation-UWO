using ProjectName.Infra.Entity.Base;

namespace ProjectName.Infra.Entity.Hierarchy
{
  public class BG : BaseEntity
  {
    public virtual IList<LE> LEs { get; set; }
  }
}
