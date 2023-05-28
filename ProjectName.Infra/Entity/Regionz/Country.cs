using ProjectName.Infra.Entity.Attributez;
using ProjectName.Infra.Entity.Base;

namespace ProjectName.Infra.Entity.Regionz
{
  public class Country : BaseEntity
  {
    public virtual IList<State>? States { get; set; }
  }
}
