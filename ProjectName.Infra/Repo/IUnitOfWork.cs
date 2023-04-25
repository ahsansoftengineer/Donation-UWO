using ProjectName.Infra.Entity;
using ProjectName.Infra.Entity.Hierarchy;

namespace ProjectName.Infra.Repo
{
  public interface IUnitOfWork : IDisposable
  {
    Task Save();

    IGenericRepo<Country> Countries { get; }  // CountryRepo ???
    IGenericRepo<Org> Orgs { get; }
    IGenericRepo<Systemz> Systemzs { get; }


  }
}
