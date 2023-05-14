using ProjectName.Domain.Model.Base;

namespace ProjectName.Domain.Model.Hierarchy
{
  public class OrgDto : BaseDtoFull { }
  public class OrgDtoWithSystemzs: OrgDto
  {
    public IList<BaseDtoRelation>? Systemzs { get; set; }
  }
  public class OrgDtoCreate : BaseDtoCreate { }
  public class OrgDtoSearch : BaseDtoSearchFull 
  {
    public string? NoPropertyInModel { get; set; } 
  }
}
