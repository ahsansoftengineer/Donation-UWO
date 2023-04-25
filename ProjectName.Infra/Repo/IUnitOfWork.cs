using ProjectName.Infra.Entity;
using ProjectName.Infra.Entity.Hierarchy;

namespace ProjectName.Infra.Repo
{
    public interface IUnitOfWork : IDisposable
  {
    IGenericRepo<Country> Countries { get; }  // CountryRepo ???
    IGenericRepo<Org> Orgs { get; }  

    Task Save();
  }
}
