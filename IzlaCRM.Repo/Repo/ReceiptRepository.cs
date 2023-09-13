using Microsoft.Extensions.Logging;
using IzlaCRM.DAL;
using IzlaCRM.Entity.Entities;
using IzlaCRM.Repo.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IzlaCRM.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace IzlaCRM.Repo.Repo
{
    public class ReceiptRepository : GenericRepository<Receipt>, IReceiptRepository
    {
        public ReceiptRepository(ApplicationDbContext context, ILogger logger) : base(context, logger)
        {
        }

        public  List<ReceiptModel> GetReceipts()
        {
            var receipts = DbSet.Include(p => p.Member).Where(x=>x.IsDeleted==false);
            return receipts.Select(o => new ReceiptModel()
            {
                Id = o.Id,
                Amount = o.Amount,
                RemainingAmount = o.RemainingAmount,
                TenantId = o.TenantId,
                IsActive = o.IsActive,
                Status = o.LookUp.DisplayName,
                Style = o.LookUp.Style,
                Member = o.Member
            }).ToList();

        }
    }
}
