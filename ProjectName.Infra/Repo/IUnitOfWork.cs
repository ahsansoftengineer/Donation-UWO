using ProjectName.Infra.Entity.Hierarchy;
using ProjectName.Infra.Entity.MadaniBastaEntity;

namespace ProjectName.Infra.Repo
{
  public interface IUnitOfWork : IDisposable
  {
    Task Save();

    IGenericRepo<Org> Orgs { get; } // Alternate of OrgRepo
    IGenericRepo<Systemz> Systemzs { get; }
    IGenericRepo<BG> BGs { get; }
    IGenericRepo<LE> LEs { get; }
    IGenericRepo<OU> OUs { get; }
    IGenericRepo<SU> SUs { get; }
    IGenericRepo<MadaniBasta> MadaniBastas { get; }
    IGenericRepo<MadaniBastaSubCategory> MadaniBastaSubCategorys { get; }
    IGenericRepo<MadaniBastaEvent> MadaniBastaEvents { get; }
    IGenericRepo<MadaniBastaPlace> MadaniBastaPlaces { get; }


  }
}
