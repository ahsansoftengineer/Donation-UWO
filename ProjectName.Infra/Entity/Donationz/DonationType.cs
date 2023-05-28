using ProjectName.Infra.Entity.Attributez;
using ProjectName.Infra.Entity.Base;
using ProjectName.Infra.Entity.Extraz;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectName.Infra.Entity.Donationz
{
  public class DonationType : BaseEntity
  {
    [ForeignKey(nameof(SysmanAccount))]
    public int SysmanAccountId { get; set; }
    [Relate]
    public virtual SysmanAccount? SysmanAccount { get; set; }

    [ForeignKey(nameof(COA))]
    public int COAId { get; set; }
    [Relate]
    public virtual COA? COA { get; set; }

    [ForeignKey(nameof(DonationCategory))]
    public int DonationCategoryId { get; set; }
    [Relate]
    public virtual DonationCategory? DonationCategory { get; set; }
  }
}
