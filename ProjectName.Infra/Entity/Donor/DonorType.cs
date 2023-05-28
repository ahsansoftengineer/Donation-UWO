using ProjectName.Infra.Entity.Attributez;
using ProjectName.Infra.Entity.Base;

namespace ProjectName.Infra.Entity.Donor
{
  public class DonorType : BaseStatusEntity
  {
    public virtual IList<DonorBasic>? DonorBasics { get; set; }
  }
}

