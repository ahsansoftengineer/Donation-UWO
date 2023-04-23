using ProjectName.Infra.Entity;

namespace ProjectName.Infra.Repo
{
  public interface IUnitOfWork : IDisposable
  {
    IGenericRepo<Country> Countries { get; }  // CountryRepo ???
    //IGenericRepo<Hotel> Hotels { get; } //

    Task Save();
  }
}
