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
    public class PreferredTimeCallBackRepository : GenericRepository<PreferredTimeCallBack>, IPreferredTimeCallBackRepository
    {
        public PreferredTimeCallBackRepository(ApplicationDbContext context, ILogger logger) : base(context, logger)
        {
        }
    }
}
