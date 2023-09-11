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
    public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(ApplicationDbContext context, ILogger logger) : base(context, logger)
        {
        }

        public List<Payment> GetPaymentByReceiptId(int id)
        {
            return DbSet.Where(p => p.ReceiptId== id).ToList();
        }
    }
}
