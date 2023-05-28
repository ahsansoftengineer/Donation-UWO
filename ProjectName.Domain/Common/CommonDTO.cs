using ProjectName.Domain.Base;
using ProjectName.Domain.Enums;

namespace ProjectName.Domain.Common
{
  public class CommonDto : BaseDtoFull { }
  public class CommonDtoCreate : BaseDtoCreate { }
  public class CommonDtoSearch : BaseDtoSearchFull { }

  public class CommonStatusDto : BaseDtoFull 
  { 
    public Status? Status { get; set; }
  }
  public class CommonStatusDtoCreate : BaseDtoCreate 
  {
    public Status? Status { get; set; } // = Status.None;
  }
  public class CommonStatusDtoSearch : BaseDtoSearchFull 
  { 
    public Status? Status { get; set; }
  }

}
