using ProjectName.Infra.Entity.Donationz;
using ProjectName.Infra.Entity.Extraz;
using ProjectName.Infra.Entity.Hierarchy;
using ProjectName.Infra.Entity.MadaniBastaEntity;

namespace ProjectName.Infra.Repo
{
  public partial class UnitOfWork : IUnitOfWork
  {
    // ??= C# 9 Short-hand Syntax
    // Hierarchy
    public IGenericRepo<Org> Orgs => _orgs ??= new GenericRepo<Org>(_context);
    public IGenericRepo<Systemz> Systemzs => _systemz ??= Got<Systemz>();
    public IGenericRepo<BG> BGs => _bgs ??= Got<BG>();
    public IGenericRepo<LE> LEs => _les ??= Got<LE>();
    public IGenericRepo<OU> OUs => _ous ??= Got<OU>();
    public IGenericRepo<SU> SUs => _sus ??= Got<SU>();
    // Madani Basta
    public IGenericRepo<MadaniBasta> MadaniBastas => _madaniBastas ??= Got<MadaniBasta>();
    public IGenericRepo<MadaniBastaSubCategory> MadaniBastaSubCategorys => _madaniBastaSubCategorys ??= Got<MadaniBastaSubCategory>();
    public IGenericRepo<MadaniBastaEvent> MadaniBastaEvents => _madaniBastaEvents ??= Got<MadaniBastaEvent>();
    public IGenericRepo<MadaniBastaPlace> MadaniBastaPlaces => _madaniBastaPlaces ??= Got<MadaniBastaPlace>();

    // Donation
    public IGenericRepo<COA> COAs => _cOAs ??= Got<COA>();
    public IGenericRepo<Locationz> Locationzs => _locations ??= Got<Locationz>();
    public IGenericRepo<Majlis> Majliss => _majliss ??= Got<Majlis>();
    public IGenericRepo<SysmanAccount> SysmanAccounts => _sysmanAccounts ??= Got<SysmanAccount>();

    // Donation
    public IGenericRepo<DonationCategory> DonationCategorys => _donationCategory ??= Got<DonationCategory>();

    public IGenericRepo<DonationCellMaster> DonationCellMasters => _donationCellMaster ??= Got<DonationCellMaster>();

    public IGenericRepo<DonationSubType> DonationSubTypes => _donationSubType ??= Got<DonationSubType>();

    public IGenericRepo<DonationType> DonationTypes => _donationType ??= Got<DonationType>();

    private GenericRepo<T> Got<T>() where T : class
    {
      return new GenericRepo<T>(_context);
    }
  }
}
