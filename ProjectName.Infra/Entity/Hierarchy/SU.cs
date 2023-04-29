using ProjectName.Infra.Entity.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectName.Infra.Entity.Hierarchy
{
  public class SU : BaseEntity
  {
    [ForeignKey(nameof(OU))]
    public int OUId { get; set; }
    public virtual OU? OU { get; set; }

  }
}
