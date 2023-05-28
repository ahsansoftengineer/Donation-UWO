using ProjectName.Infra.Entity.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectName.Infra.Entity.Hierarchy
{
  public class OU : BaseEntity
  {
    [ForeignKey(nameof(LE))]
    public int LEId { get; set; }
    public virtual LE? LE { get; set; }
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
}
