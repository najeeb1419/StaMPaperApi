using IzlaCRM.DAL;
using IzlaCRM.Entity.Entities;
using IzlaCRM.Entity.Models;
using IzlaCRM.Repo.IRepo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace IzlaCRM.Repo.Repo
{
    public class BankEmployeeReceiptRepository : GenericRepository<BankEmployeeReceipt>, IBankEmployeeReceiptRepository
    {
        public BankEmployeeReceiptRepository(ApplicationDbContext context, ILogger logger) : base(context, logger)
        {
        }

        public List<BankEmployeeReceiptModel> GetBankEmployeeReceipts()
        {
            var receipts = DbSet.Include(p => p.BankEmployee).Where(x => x.IsDeleted == false);
            return receipts.Select(o => new BankEmployeeReceiptModel()
            {
                Id = o.Id,
                Amount = o.Amount,
                RemainingAmount = o.RemainingAmount,
                TenantId = o.TenantId,
                IsActive = o.IsActive,
                Status = o.LookUp.DisplayName,
                Style = o.LookUp.Style,
                BankEmployee = o.BankEmployee
            }).ToList();

        }
    }
}
