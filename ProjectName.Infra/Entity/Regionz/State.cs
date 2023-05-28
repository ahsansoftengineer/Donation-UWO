using ProjectName.Infra.Entity.Attributez;
using ProjectName.Infra.Entity.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectName.Infra.Entity.Regionz
{
  public class State : BaseEntity
  {
    [ForeignKey(nameof(Country))]
    public int CountryId { get; set; } 
    public virtual Country? Country { get; set; }
    public virtual IList<City>? Citys { get; set; }
  }
}
