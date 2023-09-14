using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzlaCRM.Repo.IRepo
{
    public interface IUnitOfWork 
    {
        ICountryRepository CountryRepository { get; }
        IBillingShippingRepository BillingShippingRepository { get; }
        IBusinessTypeRepository BusinessTypeRepository { get; }
        ICurrencyRepository CurrencyRepository { get; }
        ICustomerBusinessServiceRepository CustomerBusinessServiceRepository { get; }
        ICustomerContactRepository CustomerContactRepository { get; }
        ICustomerRepository CustomerRepository { get; }
        IRoleRepository RoleRepository { get; }
        ILanguageRepository LanguageRepository { get; }

        IServiceRepository ServiceRepository { get; }
        ITenantRepository TenantRepository { get; }
        IUserRepository UserRepository { get; }

        IPermissionRepository PermissionRepository { get; }
        IRolePermissionRepository RolePermissionRepository { get; }

        IDiscountTypeRepository DiscountTypeRepository { get; }
        ILeadRepository LeadRepository { get; }
        ILeadStatusRepository LeadStatusRepository { get; }
        IProposalRepository ProposalRepository { get; }
        IProfileRepository ProfileRepository { get; }
        IPackageRepository PackageRepository { get; }
        ITaskRepository TaskRepository { get; }
        IServiceCategoryRepository ServiceCategoryRepository { get; }
        IUserRoleRepository UserRoleRepository { get; }
        ILeadSourceRepository LeadSourceRepository { get; }
        ICityRepository CityRepository { get; }
        IPreferredTimeCallBackRepository PreferredTimeCallBackRepository { get; }
        ILeadProfileServiceRepository LeadProfileServiceRepository { get; }
        INoteRepository NoteRepository { get; }
        IAccountRepository AccountRepository { get; }
        IBankEmployeeReceiptRepository BankEmployeeReceiptRepository { get; }
        IBankEmployeeRepository BankEmployeeRepository { get; }
        IMemberRepository MemberRepository { get; }
        IPaymentRepository PaymentRepository { get; }
        IReceiptRepository ReceiptRepository { get; }
        IBankEmployeePaymentRepository BankEmployeePaymentRepository { get; }
        Task BeginTransactionAsync();
        Task CommitAsync();
        Task RollbackAsync();
        Task SaveChangesAsync();
    }
}
