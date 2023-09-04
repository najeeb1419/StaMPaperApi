using IzlaCRM.DAL;
using IzlaCRM.Entity.Entities;
using IzlaCRM.Repo.IRepo;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzlaCRM.Repo.Repo
{
    public class CustomerBusinessServiceRepository : GenericRepository<CustomerBussinessService>, ICustomerBusinessServiceRepository
    {
        public CustomerBusinessServiceRepository(ApplicationDbContext context, ILogger logger) : base(context, logger)
        {
        }
    }
 
}
