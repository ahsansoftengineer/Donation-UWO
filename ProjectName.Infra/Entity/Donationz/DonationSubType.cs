using ProjectName.Infra.Entity.Attributez;
using ProjectName.Infra.Entity.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectName.Infra.Entity.Donationz
{
  public class DonationSubType : BaseEntity
  {
    //[ForeignKey(nameof(DonationCategory))]
    //public int DonationCategoryId { get; set; }
    //public virtual DonationCategory? DonationCategory { get; set; }

    [ForeignKey(nameof(DonationType))]
    public int DonationTypeId { get; set; }
    [Relate]
    public virtual DonationType? DonationType { get; set; }
  }
}
