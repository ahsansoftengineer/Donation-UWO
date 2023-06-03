using ProjectName.Domain.Enums;
using ProjectName.Infra.Entity.Extraz;
using ProjectName.Infra.Entity.Hierarchy;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectName.Infra.Entity.Donor
{
  [Table("DonorGSB")]
  public class DonorGSB : DonorBasic
  {
    //[ForeignKey(nameof(DonorBasic))]
    //public int? Id { get; set; }
    //public virtual DonorBasic? DonorBasic { get; set; }

    public string? Area { get; set; }
    public string? NearBy { get; set; }

    [ForeignKey(nameof(SU))]
    public int SubUnitId { get; set; }
    public virtual SU? SU { get; set; }

    public YesNo? WillingToJoinDI { get; set; }

    [ForeignKey(nameof(Majlis))]
    public int? DepartmentId { get; set; }
    public virtual Majlis? Department { get; set; }

    [ForeignKey(nameof(Branch))]
    public int? BranchId { get; set; }
    public virtual Branch? Branch { get; set; }

    // FollowUp Conditional With Followup Date
    public YesNo Followup { get; set; }
    public int? FollowupDate { get; set; }
    public DonationOption DonationOption { get; set; }
    // GSB: "", Self: Amount, Marhoom: {Name, Amount}
    public string? DonationOptionData { get; set; }
    //public int? AmountSelf { get; set; }
    //public virtual IList<DonorMarhoom>? DonorMarhooms { get; set; }
  }
}
