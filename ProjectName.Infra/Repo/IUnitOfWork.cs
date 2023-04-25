using ProjectName.Infra.Entity;
using ProjectName.Infra.Entity.Hierarchy;

namespace ProjectName.Infra.Repo
{
  public interface IUnitOfWork : IDisposable
  {
    Task Save();

    IGenericRepo<Org> Orgs { get; } // Alternate of OrgRepo
    IGenericRepo<Systemz> Systemzs { get; }
    IGenericRepo<BG> BGs { get; }


  }
}
