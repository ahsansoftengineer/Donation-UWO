using ProjectName.Infra.Entity.Base;
using ProjectName.Infra.Entity.Extraz;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectName.Infra.Entity.Donationz
{
  public class DonationType : BaseEntity
  {
    [ForeignKey(nameof(SysmanAccount))]
    public int SysmanAccountId { get; set; }
    public virtual SysmanAccount? SysmanAccount { get; set; }

    [ForeignKey(nameof(COA))]
    public int COAId { get; set; }
    public virtual COA? COA { get; set; }

    [ForeignKey(nameof(DonationCategory))]
    public int DonationCategoryId { get; set; }
    public virtual DonationCategory? DonationCategory { get; set; }
  }
}
