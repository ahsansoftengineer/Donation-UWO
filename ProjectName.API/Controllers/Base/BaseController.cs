using AutoMapper;
using ProjectName.Infra.Repo;

namespace ProjectName.API.Controllers.Base
{
  // It Remains Because I don't want to break Exsisting Functionality
  public abstract class BaseController<TController> : AlphaController<TController>
  {
    public BaseController(ILogger<TController> logger, IMapper mapper, IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    {
    }
  }
}
