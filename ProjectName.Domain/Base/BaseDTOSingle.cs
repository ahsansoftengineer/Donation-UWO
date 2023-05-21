using System.Net;

namespace ProjectName.Domain.Base
{
  public class BaseDtoSingle<T>
  {
    public T? Record { get; set; }
    public HttpStatusCode Status { get; set; }
  }
}
