using Castle.MicroKernel.Util;
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
    public class NoteRepository : GenericRepository<Note>, INoteRepository
    {
        public NoteRepository(ApplicationDbContext context, ILogger logger) : base(context, logger)
        {
        }

        public IEnumerable<Note>? GetNotes (int TenantId, int LeadProfileId)
        {
            var res = DbSet.Where(p => p.TenantId == TenantId && p.LeadProfileId == LeadProfileId && p.IsActive ==true);
            return res;
        }
    }
}
