using ProjectName.Infra.Entity.Base;

namespace ProjectName.Infra.Entity.MadaniBastaEntity
{
  public class MadaniBasta : BaseEntity 
  {
    public virtual IList<MadaniBastaSubCategory>? MadaniBastaSubCategorys { get; set; }

  }
}
