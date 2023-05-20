using ProjectName.Domain.Base;

namespace ProjectName.Domain.DTOs.MadaniBastaDTOz
{
  public class MadaniBastaSubCategoryDto : BaseDtoFull
  {
    public int MadaniBastaId { get; set; }
    public BaseDtoRelation? MadaniBasta { get; set; }
  }
  public class MadaniBastaSubCategoryDtoCreate : BaseDtoCreate
  {
    public int MadaniBastaId { get; set; }
  }

  public class MadaniBastaSubCategoryDtoSearch : BaseDtoSearchFull
  {
    public int? MadaniBastaId { get; set; }
  }


}
