using ProjectName.Infra.Entity.Base;
using ProjectName.Infra.Entity.Extraz;
using ProjectName.Infra.Entity.Hierarchy;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectName.Infra.Entity.Donationz
{
  public class DonationCellMaster : BaseEntity
  {
    public string? Address { get; set; }

    [ForeignKey(nameof(Locationz))]
    public int LocationzId { get; set; }
    public virtual Locationz? Locationz { get; set; }

    [ForeignKey(nameof(Majlis))]
    public int MajlisId { get; set; }
    public virtual Majlis? Majlis { get; set; }

    [ForeignKey(nameof(BG))]
    public int BGId { get; set; }
    public virtual BG? BG { get; set; }

    [ForeignKey(nameof(LE))]
    public int LEId { get; set; }
    public virtual LE? LE { get; set; }

    [ForeignKey(nameof(OU))]
    public int OUId { get; set; }
    public virtual OU? OU { get; set; }

    [ForeignKey(nameof(SU))]
    public int SUId { get; set; }
    public virtual SU? SU { get; set; }
  }
}