using AutoMapper;
using ProjectName.Infra.Repo;

namespace ProjectName.API.Controllers.Base
{
  public abstract class BaseController<TEntity> : AlphaController<TEntity>
  {
    public BaseController(ILogger<TEntity> logger, IMapper mapper, IUnitOfWork unitOfWork) : base(logger, mapper, unitOfWork)
    {
    }
  }
}
