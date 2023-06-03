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
    public string? DonationOptionData { get; set; }
    public List<DonorGSBOptionMarhoom>? donorGSBOptionMarhooms
    {
      get
      {
        if (!string.IsNullOrEmpty(DonationOptionData))
        {
          if(DonationOptionData.IndexOf("name") != -1)
          {
            return JsonConvert.DeserializeObject
              <List<DonorGSBOptionMarhoom>>(DonationOptionData);
          }
        
        }
        return null;

      }
      set
      {
        if (value != null) DonationOptionData = JsonConvert.SerializeObject(value);
      }
    }
    public int? donorGSBOptionSelf
    {
      get
      {
        int.TryParse(DonationOptionData, out int result);
        return result;
      }
      set
      {
        if (value != null) DonationOptionData = JsonConvert.SerializeObject(value);
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
    public string? DonationOptionData { get; set; }
    public List<DonorGSBOptionMarhoom>? donorGSBOptionMarhooms
    {
      get
      {
        if (!string.IsNullOrEmpty(DonationOptionData))
        {
          if (DonationOptionData.IndexOf("name") != -1)
          {
            return JsonConvert.DeserializeObject
              <List<DonorGSBOptionMarhoom>>(DonationOptionData);
          }

        }
        return null;

      }
      set
      {
        if (value != null) DonationOptionData = JsonConvert.SerializeObject(value);
      }
    }
    public int? donorGSBOptionSelf
    {
      get
      {
        int.TryParse(DonationOptionData, out int result);
        return result;
      }
      set
      {
        if (value != null) DonationOptionData = JsonConvert.SerializeObject(value);
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
    public string? DonationOptionData { get; set; }
    public List<DonorGSBOptionMarhoom>? donorGSBOptionMarhooms
    {
      get
      {
        if (!string.IsNullOrEmpty(DonationOptionData))
        {
          if (DonationOptionData.IndexOf("name") != -1)
          {
            return JsonConvert.DeserializeObject
              <List<DonorGSBOptionMarhoom>>(DonationOptionData);
          }

        }
        return null;

      }
      set
      {
        if (value != null) DonationOptionData = JsonConvert.SerializeObject(value);
      }
    }
    public int? donorGSBOptionSelf
    {
      get
      {
        int.TryParse(DonationOptionData, out int result);
        return result;
      }
      set
      {
        if (value != null) DonationOptionData = JsonConvert.SerializeObject(value);
      }
    }
  }
}
