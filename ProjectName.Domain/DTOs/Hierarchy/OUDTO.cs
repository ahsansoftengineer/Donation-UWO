using ProjectName.Domain.Base;

namespace ProjectName.Domain.DTOs.Hierarchy
{
  public class OUDtoCreate : BaseDtoCreate
  {
    public int LEId { get; set; }
    public string? Law { get; set; }
    public string? Address { get; set; }
    public string? Deposit { get; set; }
    public string? LogoImg { get; set; }
    public string? LogoImage { get; set; }
    public string? TopImg { get; set; }
    public string? TopImage { get; set; }
    public string? WarningImage { get; set; }
    public string? WarningImg { get; set; }
    public string? FooterImage { get; set; }
    public string? FooterImg { get; set; }

  }
  public class OUDto : BaseDtoFull
  {
    public int LEId { get; set; }
    public BaseDtoRelation? LE { get; set; }
    public string? Law { get; set; }
    public string? Address { get; set; }
    public string? Deposit { get; set; }
    public string? LogoImg { get; set; }
    public string? TopImg { get; set; }
    public string? WarningImg { get; set; }
    public string? FooterImg { get; set; }

  }
  public class OUDtoSearch : BaseDtoSearchFull
  {
    public int? LEId { get; set; }
    public string? Law { get; set; }
    public string? Address { get; set; }
    public string? Deposit { get; set; }
    public string? LogoImg { get; set; }
    public string? TopImg { get; set; }
    public string? WarningImg { get; set; }
    public string? FooterImg { get; set; }
  }
}
