using ProjectName.Infra.Entity.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectName.Infra.Entity.Hierarchy
{
  public class Systemz : BaseEntity
  {
    [ForeignKey(nameof(Org))]
    public int OrgId { get; set; } // We Marked it as Nullable because of Dynamic Filtering
    public virtual Org? Org { get; set; }

  }
}
