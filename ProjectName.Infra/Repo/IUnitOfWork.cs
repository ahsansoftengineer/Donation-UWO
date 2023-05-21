using ProjectName.Infra.Entity.Donationz;
using ProjectName.Infra.Entity.Extraz;
using ProjectName.Infra.Entity.Hierarchy;
using ProjectName.Infra.Entity.MadaniBastaEntity;

namespace ProjectName.Infra.Repo
{
  public interface IUnitOfWork : IDisposable
  {
    Task Save();
    // HIERARCHY
    IGenericRepo<Org> Orgs { get; } // Alternate of OrgRepo
    IGenericRepo<Systemz> Systemzs { get; }
    IGenericRepo<BG> BGs { get; }
    IGenericRepo<LE> LEs { get; }
    IGenericRepo<OU> OUs { get; }
    IGenericRepo<SU> SUs { get; }

    // MADNI BASTA
    IGenericRepo<MadaniBasta> MadaniBastas { get; }
    IGenericRepo<MadaniBastaSubCategory> MadaniBastaSubCategorys { get; }
    IGenericRepo<MadaniBastaEvent> MadaniBastaEvents { get; }
    IGenericRepo<MadaniBastaPlace> MadaniBastaPlaces { get; }


    // EXTRAS
    IGenericRepo<COA> COAs { get; }
    IGenericRepo<Locationz> Locationzs { get; }
    IGenericRepo<Majlis> Majliss { get; }
    IGenericRepo<SysmanAccount> SysmanAccounts { get; }

    // Donation
    IGenericRepo<DonationCategory> DonationCategorys { get; }
    IGenericRepo<DonationCellMaster> DonationCellMasters { get; }
    IGenericRepo<DonationSubType> DonationSubTypes { get; }
    IGenericRepo<DonationType> DonationTypes { get; }

  }
}
