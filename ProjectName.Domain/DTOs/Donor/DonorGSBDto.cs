using Newtonsoft.Json;
using ProjectName.Domain.Base;
using ProjectName.Domain.Enums;

namespace ProjectName.Domain.DTOs.Donor
{
  public class DonorGSBDto : DonorBasicDto
  {
    public string? Area { get; set; }
    public string? NearBy { get; set; }
    public int SubUnitId { get; set; }
    public YesNo? WillingToJoinDI { get; set; }
    public int? DepartmentId { get; set; }
    public int? BranchId { get; set; }
    public YesNo Followup { get; set; }
    public int? FollowupDate { get; set; }
    public DonationOption DonationOption { get; set; }
    protected string? DonationOptionData { get; set; }
    public List<DonorGSBOptionMarhoom>? donorGSBOptionMarhooms
    {
      get
      {
        return JsonConvert.DeserializeObject
          <List<DonorGSBOptionMarhoom>>(DonationOptionData);
      }
      set
      {
        DonationOptionData = JsonConvert.SerializeObject(value);
      }
    }
    public DonorGSBOptionSelf? donorGSBOptionSelf
    {
      get
      {
        return JsonConvert.DeserializeObject
          <DonorGSBOptionSelf>(DonationOptionData);
      }
      set
      {
        DonationOptionData = JsonConvert.SerializeObject(value);
      }
    }
    public virtual BaseDtoRelation? SU { get; set; }
    public virtual BaseDtoRelation? Department { get; set; }
    public virtual BaseDtoRelation? Branch { get; set; }
  }
  public class DonorGSBDtoCreate : DonorBasicDtoCreate
  {
    public string? Area { get; set; }
    public string? NearBy { get; set; }
    public int SubUnitId { get; set; }
    public YesNo WillingToJoinDI { get; set; }
    public int? DepartmentId { get; set; }
    public int? BranchId { get; set; }
    public YesNo Followup { get; set; }
    public int? FollowupDate { get; set; }
    public DonationOption DonationOption { get; set; }
    protected string? DonationOptionData { get; set; }
    public List<DonorGSBOptionMarhoom>? donorGSBOptionMarhooms
    {
      get
      {
        return JsonConvert.DeserializeObject
          <List<DonorGSBOptionMarhoom>>(DonationOptionData);
      }
      set
      {
        DonationOptionData = JsonConvert.SerializeObject(value);
      }
    }
    public DonorGSBOptionSelf? donorGSBOptionSelf
    {
      get
      {
        return JsonConvert.DeserializeObject
          <DonorGSBOptionSelf>(DonationOptionData);
      }
      set
      {
        DonationOptionData = JsonConvert.SerializeObject(value);
      }
    }
  }
  public class DonorGSBDtoSearch : DonorBasicDtoSearch
  {
    public string? Area { get; set; }
    public string? NearBy { get; set; }
    public int? SubUnitId { get; set; }
    public YesNo? WillingToJoinDI { get; set; }
    public int? DepartmentId { get; set; }
    public int? BranchId { get; set; }
    public YesNo? Followup { get; set; }
    public int? FollowupDate { get; set; }
    public DonationOption? DonationOption { get; set; }
    protected string? DonationOptionData { get; set; }
    public List<DonorGSBOptionMarhoom>? donorGSBOptionMarhooms
    {
      get
      {
        return JsonConvert.DeserializeObject
          <List<DonorGSBOptionMarhoom>>(DonationOptionData);
      }
      set
      {
        DonationOptionData = JsonConvert.SerializeObject(value);
      }
    }
    public DonorGSBOptionSelf? donorGSBOptionSelf
    {
      get
      {
        return JsonConvert.DeserializeObject
          <DonorGSBOptionSelf>(DonationOptionData);
      }
      set
      {
        DonationOptionData = JsonConvert.SerializeObject(value);
      }
    }
  }
}
