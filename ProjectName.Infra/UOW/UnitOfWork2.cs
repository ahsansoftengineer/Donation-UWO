using ProjectName.Infra.Entity.Donationz;
using ProjectName.Infra.Entity.Donor;
using ProjectName.Infra.Entity.Extraz;
using ProjectName.Infra.Entity.Hierarchy;
using ProjectName.Infra.Entity.MadaniBastaEntity;
using ProjectName.Infra.Entity.Regionz;
using ProjectName.Infra.UOW;

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

    // Extraz
    public IGenericRepo<COA> COAs => _cOAs ??= Got<COA>();
    public IGenericRepo<Locationz> Locationzs => _locations ??= Got<Locationz>();
    public IGenericRepo<Majlis> Majliss => _majliss ??= Got<Majlis>();
    public IGenericRepo<SysmanAccount> SysmanAccounts => _sysmanAccounts ??= Got<SysmanAccount>();
    public IGenericRepo<Branch> Branchs => _branch ??= Got<Branch>();

    // Regionz
    public IGenericRepo<Country> Countrys => _countrys ??= Got<Country>();
    public IGenericRepo<State> States => _states ??= Got<State>();
    public IGenericRepo<City> Citys => _citys ??= Got<City>();


    // Madani Basta
    public IGenericRepo<MadaniBasta> MadaniBastas => _madaniBastas ??= Got<MadaniBasta>();
    public IGenericRepo<MadaniBastaSubCategory> MadaniBastaSubCategorys => _madaniBastaSubCategorys ??= Got<MadaniBastaSubCategory>();
    public IGenericRepo<MadaniBastaEvent> MadaniBastaEvents => _madaniBastaEvents ??= Got<MadaniBastaEvent>();
    public IGenericRepo<MadaniBastaPlace> MadaniBastaPlaces => _madaniBastaPlaces ??= Got<MadaniBastaPlace>();

    // Donation
    public IGenericRepo<DonationCategory> DonationCategorys => _donationCategorys ??= Got<DonationCategory>();
    public IGenericRepo<DonationCellMaster> DonationCellMasters => _donationCellMasters ??= Got<DonationCellMaster>();
    public IGenericRepo<DonationSubType> DonationSubTypes => _donationSubTypes ??= Got<DonationSubType>();
    public IGenericRepo<DonationType> DonationTypes => _donationTypes ??= Got<DonationType>(); 
    public IGenericRepo<TargetAssignment> TargetAssignments => _targetAssignments ??= Got<TargetAssignment>();

    // Donor
    public IGenericRepo<DonorType> DonorTypes => _donorTypes ??= Got<DonorType>();
    public IGenericRepo<DonorBasic> DonorBasics => _donorBasics ??= Got<DonorBasic>();
    public IGenericRepo<DonorGSB> DonorGSBs => _donorGsbs ??= Got<DonorGSB>();
  }
}
