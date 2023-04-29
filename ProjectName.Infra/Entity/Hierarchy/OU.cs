using ProjectName.Infra.Entity.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectName.Infra.Entity.Hierarchy
{
  public class OU : BaseEntity
  {
    [ForeignKey(nameof(LE))]
    public int LEId { get; set; }
    public virtual LE? LE { get; set; }

  }
}
