using IzlaCRM.DAL;
using IzlaCRM.Entity.Entities;
using IzlaCRM.Repo.IRepo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzlaCRM.Repo.Repo
{
    public class BusinessTypeRepository : GenericRepository<BusinessType>, IBusinessTypeRepository
    {
        public BusinessTypeRepository(ApplicationDbContext context, ILogger logger) : base(context, logger)
        {
        }
      public IEnumerable<BusinessType> GetBusinessTypes(int TenantId) {

            var res = DbSet.Where(p => p.TenantId == TenantId && p.IsActive == true);
            return res;
        
        }
    }
}
