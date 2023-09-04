using IzlaCRM.DAL;
using IzlaCRM.Entity.Entities;
using IzlaCRM.Repo.IRepo;
using Microsoft.Extensions.Logging;

namespace IzlaCRM.Repo.Repo
{
    public class BankEmployeeRepository : GenericRepository<BankEmployee>, IBankEmployeeRepository
    {
        public BankEmployeeRepository(ApplicationDbContext context, ILogger logger) : base(context, logger)
        {
        }
    }
}
