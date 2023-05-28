using ProjectName.Infra.Entity.Hierarchy;
using ProjectName.Infra.Entity.MadaniBastaEntity;
using ProjectName.Infra.Entity.Extraz;
using ProjectName.Infra.Entity.Donationz;
using ProjectName.Infra.Entity.Donor;
using ProjectName.Infra.Entity.Regionz;

namespace ProjectName.Infra.Repo
{
  public partial class UnitOfWork
  {
    // Hierarchy
    private IGenericRepo<Org>? _orgs;
    private IGenericRepo<Systemz>? _systemz;
    private IGenericRepo<BG>? _bgs;
    private IGenericRepo<LE>? _les;
    private IGenericRepo<OU>? _ous;
    private IGenericRepo<SU>? _sus;

    // Extra
    private IGenericRepo<COA>? _cOAs;
    private IGenericRepo<Locationz>? _locations;
    private IGenericRepo<Majlis>? _majliss;
    private IGenericRepo<SysmanAccount>? _sysmanAccounts;

    // Regionz
    private IGenericRepo<Country>? _countrys;
    private IGenericRepo<State>? _states;
    private IGenericRepo<City>? _citys;

    // MadaniBasta
    private IGenericRepo<MadaniBasta>? _madaniBastas;
    private IGenericRepo<MadaniBastaSubCategory>? _madaniBastaSubCategorys;
    private IGenericRepo<MadaniBastaEvent>? _madaniBastaEvents;
    private IGenericRepo<MadaniBastaPlace>? _madaniBastaPlaces;

    // Donation
    private IGenericRepo<DonationCategory>? _donationCategorys;
    private IGenericRepo<DonationCellMaster>? _donationCellMasters;
    private IGenericRepo<DonationSubType>? _donationSubTypes;
    private IGenericRepo<DonationType>? _donationTypes;
    private IGenericRepo<TargetAssignment>? _targetAssignments;

    // Donor
    private IGenericRepo<DonorType>? _donorTypes;
    private IGenericRepo<DonorBasic>? _donorBasics;
  }
}
