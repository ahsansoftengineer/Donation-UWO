using ProjectName.Infra.Entity.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectName.Infra.Entity.MadaniBastaEntity
{
  public class MadaniBastaSubCategory : BaseEntity
  {
    [ForeignKey(nameof(MadaniBasta))]
    public int MadaniBastaId { get; set; } // We Marked it as Nullable because of Dynamic Filtering
    public virtual MadaniBasta? MadaniBasta { get; set; }

  }
}
