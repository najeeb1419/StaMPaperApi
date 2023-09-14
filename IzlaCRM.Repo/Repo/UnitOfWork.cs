using IzlaCRM.DAL;
using IzlaCRM.Repo.IRepo;
using Microsoft.Extensions.Logging;

namespace IzlaCRM.Repo.Repo
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger _logger;
        private ICountryRepository _countryRepository;
        private IBillingShippingRepository _billingShippingRepository;
        private IBusinessTypeRepository _businessTypeRepository;
        private ICurrencyRepository _currencyRepository;
        private ICustomerBusinessServiceRepository _customerBusinessServiceRepository;
        private ICustomerContactRepository _customerContactRepository;
        private ICustomerRepository _customerRepository;
        private IRoleRepository _roleRepository;
        private ILanguageRepository _languageRepository;
        private IServiceRepository _serviceRepository;
        private ITenantRepository _tenantRepository;
        private IUserRepository _userRepository;
        private IRolePermissionRepository _rolePermissionRepository;
        private IPermissionRepository _permissionRepository;
        private IDiscountTypeRepository _discountTypeRepository;
        private ILeadRepository _leadRepository;
        private ILeadStatusRepository _leadStatusRepository;
        private IProposalRepository _proposalRepository;
        private IProfileRepository _profileRepository;
        private IPackageRepository _packageRepository;
        private ITaskRepository _taskRepository;
        private IServiceCategoryRepository _serviceCategoryRepository;
        private IUserRoleRepository _userRoleRepository;
        private ILeadSourceRepository _leadSourceRepository;
        private ICityRepository _cityRepository;
        private IPreferredTimeCallBackRepository _preferredTimeCallBackRepository;
        private ILeadProfileServiceRepository _leadProfileServiceRepository;
        private INoteRepository _noteRepository;
        private IAccountRepository _accountRepository;
        private IBankEmployeeReceiptRepository _bankEmployeeReceiptRepository;
        private IBankEmployeeRepository _bankEmployeeRepository;
        private IMemberRepository _memberRepository;
        private IPaymentRepository _paymentRepository;
        private IReceiptRepository _receiptRepository;
        private IBankEmployeePaymentRepository _bankEmployeePaymentRepository;
        public IUserRepository UserRepository
        {
            get { _userRepository ??= new UserRepository(_context, _logger); return _userRepository; }
        }
        public ICountryRepository CountryRepository
        {
            get { _countryRepository ??= new CountryRepository(_context, _logger); return _countryRepository; }
        }
        public IBillingShippingRepository BillingShippingRepository
        {
            get { _billingShippingRepository ??= new BillingShippingRepository(_context, _logger); return _billingShippingRepository; }
        }
        public IBusinessTypeRepository BusinessTypeRepository
        {
            get { _businessTypeRepository ??= new BusinessTypeRepository(_context, _logger); return _businessTypeRepository; }
        }
        public ICurrencyRepository CurrencyRepository
        {
            get { _currencyRepository ??= new CurrencyRepository(_context, _logger); return _currencyRepository; }
        }
        public ICustomerBusinessServiceRepository CustomerBusinessServiceRepository
        {
            get { _customerBusinessServiceRepository ??= new CustomerBusinessServiceRepository(_context, _logger); return _customerBusinessServiceRepository; }
        }
        public ICustomerContactRepository CustomerContactRepository
        {
            get { _customerContactRepository ??= new CustomerContactRepository(_context, _logger); return _customerContactRepository; }
        }
        public ICustomerRepository CustomerRepository
        {
            get { _customerRepository ??= new CustomerRepository(_context, _logger); return _customerRepository; }
        }
        public IRoleRepository RoleRepository
        {
            get { _roleRepository ??= new RoleRepository(_context, _logger); return _roleRepository; }
        }
        public ILanguageRepository LanguageRepository
        {
            get { _languageRepository ??= new LanguageRepository(_context, _logger); return _languageRepository; }
        }
        public IServiceRepository ServiceRepository
        {
            get { _serviceRepository ??= new ServiceRepository(_context, _logger); return _serviceRepository; }
        }
        public ITenantRepository TenantRepository
        {
            get { _tenantRepository ??= new TenantRepository(_context, _logger); return _tenantRepository; }
        }

        public IPermissionRepository PermissionRepository
        {
            get { _permissionRepository ??= new PermissionRepository(_context, _logger); return _permissionRepository; }
        }
        public IRolePermissionRepository RolePermissionRepository
        {
            get { _rolePermissionRepository ??= new RolePermissionRepository(_context, _logger); return _rolePermissionRepository; }
        }

        public IDiscountTypeRepository DiscountTypeRepository
        {
            get { _discountTypeRepository ??= new DiscountTypeRepository(_context, _logger); return _discountTypeRepository; }
        }
        public ILeadRepository LeadRepository
        {
            get { _leadRepository ??= new LeadRepository(_context, _logger); return _leadRepository; }
        }
        public ILeadStatusRepository LeadStatusRepository
        {
            get { _leadStatusRepository ??= new LeadStatusRepository(_context, _logger); return _leadStatusRepository; }
        }
        public IProposalRepository ProposalRepository
        {
            get { _proposalRepository ??= new ProposalRepository(_context, _logger); return _proposalRepository; }
        }
        public IProfileRepository ProfileRepository
        {
            get { _profileRepository ??= new ProfileRepository(_context, _logger); return _profileRepository; }
        }
        public IPackageRepository PackageRepository
        {
            get { _packageRepository ??= new PackageRepository(_context, _logger); return _packageRepository; }
        }
        public ITaskRepository TaskRepository
        {
            get { _taskRepository ??= new TaskRepository(_context, _logger); return _taskRepository; }
        }
        public IServiceCategoryRepository ServiceCategoryRepository
        {
            get { _serviceCategoryRepository ??= new ServiceCategoryRepository(_context, _logger); return _serviceCategoryRepository; }
        }
        public IUserRoleRepository UserRoleRepository
        {
            get { _userRoleRepository ??= new UserRoleRepository(_context, _logger); return _userRoleRepository; }
        }
        public ILeadSourceRepository LeadSourceRepository
        {
            get { _leadSourceRepository ??= new LeadSourceRepository(_context, _logger); return _leadSourceRepository; }
        }
        public ICityRepository CityRepository
        {
            get { _cityRepository ??= new CityRepository(_context, _logger); return _cityRepository; }
        }

        public IPreferredTimeCallBackRepository PreferredTimeCallBackRepository
        {
            get { _preferredTimeCallBackRepository ??= new PreferredTimeCallBackRepository(_context, _logger); return _preferredTimeCallBackRepository; }
        }
        public ILeadProfileServiceRepository LeadProfileServiceRepository
        {
            get { _leadProfileServiceRepository ??= new LeadProfileServiceRepository(_context, _logger); return _leadProfileServiceRepository; }
        }

        public INoteRepository NoteRepository
        {
            get { _noteRepository ??= new NoteRepository(_context, _logger); return _noteRepository; }
        }
        public IAccountRepository AccountRepository
        {
            get { _accountRepository ??= new AccountRepository(_context, _logger); return _accountRepository; }
        }
        public IBankEmployeeReceiptRepository BankEmployeeReceiptRepository
        {
            get { _bankEmployeeReceiptRepository ??= new BankEmployeeReceiptRepository(_context, _logger); return _bankEmployeeReceiptRepository; }
        }
        public IBankEmployeeRepository BankEmployeeRepository
        {
            get { _bankEmployeeRepository ??= new BankEmployeeRepository(_context, _logger); return _bankEmployeeRepository; }
        }

        public IMemberRepository MemberRepository
        {
            get { _memberRepository ??= new MemberRepository(_context, _logger); return _memberRepository; }
        }
        public IPaymentRepository PaymentRepository
        {
            get { _paymentRepository ??= new PaymentRepository(_context, _logger); return _paymentRepository; }
        }
        public IReceiptRepository ReceiptRepository
        {
            get { _receiptRepository ??= new ReceiptRepository(_context, _logger); return _receiptRepository; }
        }

        public IBankEmployeePaymentRepository BankEmployeePaymentRepository
        {
            get { _bankEmployeePaymentRepository ??= new BankEmployeePaymentRepository(_context, _logger); return _bankEmployeePaymentRepository; }
        }

        public UnitOfWork(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {

            _context = context;
            _logger = loggerFactory.CreateLogger("logs");

        }
        public async Task BeginTransactionAsync()
        {
            await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
                await _context.Database.CommitTransactionAsync();
            }
            catch
            {
                await RollbackAsync();
                throw;
            }
            finally
            {
                _context.Dispose();
            }
        }

        public async Task RollbackAsync()
        {
            await _context.Database.RollbackTransactionAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
            _context.Dispose();
        }
    }
}
