using ProjectName.Domain.Enums;
using ProjectName.Infra.Entity.Base;
using ProjectName.Infra.Entity.Hierarchy;
using ProjectName.Infra.Entity.Regionz;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectName.Infra.Entity.Donor
{
  public class DonorBasic : BaseEntity
  {
    public string? Mobile { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }
    //[NotMapped]
    public Gender? Gender { get; set; }// = Gender.None;

    [ForeignKey(nameof(DonorType))]
    public int DonorTypeId { get; set; }
    public virtual DonorType? DonorType { get; set; }

    [ForeignKey(nameof(Org))]
    public int OrgId { get; set; }
    public virtual Org? Org { get; set; }

    [ForeignKey(nameof(City))]
    public int CityId { get; set; }
    public virtual City? City { get; set; }

    [ForeignKey(nameof(DonorGSB))]
    public int? DonorGSBId { get; set; }
    public virtual DonorGSB? DonorGSB { get; set; }
  }
}
