using IzlaCRM.DAL;
using IzlaCRM.Entity.Entities;
using IzlaCRM.Repo.IRepo;
using Microsoft.Extensions.Logging;

namespace IzlaCRM.Repo.Repo
{
    public class BankEmployeeReceiptRepository : GenericRepository<BankEmployeeReceipt>, IBankEmployeeReceiptRepository
    {
        public BankEmployeeReceiptRepository(ApplicationDbContext context, ILogger logger) : base(context, logger)
        {
        }
    }
}
