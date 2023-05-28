using ProjectName.Infra.Entity.Attributez;
using ProjectName.Infra.Entity.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectName.Infra.Entity.Hierarchy
{
  public class LE : BaseEntity
  {
    [ForeignKey(nameof(BG))]
    public int BGId { get; set; }
    public virtual BG? BG { get; set; }

  }
}
