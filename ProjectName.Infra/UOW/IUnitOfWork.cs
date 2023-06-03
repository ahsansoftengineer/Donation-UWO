using ProjectName.Infra.Entity.Donationz;
using ProjectName.Infra.Entity.Donor;
using ProjectName.Infra.Entity.Extraz;
using ProjectName.Infra.Entity.Hierarchy;
using ProjectName.Infra.Entity.MadaniBastaEntity;
using ProjectName.Infra.Entity.Regionz;
using ProjectName.Infra.Repo;

namespace ProjectName.Infra.UOW
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

    // EXTRAS
    IGenericRepo<COA> COAs { get; }
    IGenericRepo<Locationz> Locationzs { get; }
    IGenericRepo<Majlis> Majliss { get; }
    IGenericRepo<SysmanAccount> SysmanAccounts { get; }
    IGenericRepo<Branch> Branchs { get; }
    // Regionz
    IGenericRepo<Country> Countrys { get; }
    IGenericRepo<State> States { get; }
    IGenericRepo<City> Citys { get; }

    // MADNI BASTA
    IGenericRepo<MadaniBasta> MadaniBastas { get; }
    IGenericRepo<MadaniBastaSubCategory> MadaniBastaSubCategorys { get; }
    IGenericRepo<MadaniBastaEvent> MadaniBastaEvents { get; }
    IGenericRepo<MadaniBastaPlace> MadaniBastaPlaces { get; }

    // Donation
    IGenericRepo<DonationCategory> DonationCategorys { get; }
    IGenericRepo<DonationCellMaster> DonationCellMasters { get; }
    IGenericRepo<DonationSubType> DonationSubTypes { get; }
    IGenericRepo<DonationType> DonationTypes { get; }
    IGenericRepo<TargetAssignment> TargetAssignments { get; }

    // Donor
    IGenericRepo<DonorType> DonorTypes { get; }
    IGenericRepo<DonorBasic> DonorBasics { get; }
    IGenericRepo<DonorGSB> DonorGSBs { get; }

  }
}
