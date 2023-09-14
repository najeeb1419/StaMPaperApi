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

        public List<PaymentModel> GetPaymentByReceiptId(int id)
        {
            var result = DbSet.Include(x=>x.Account).Where(p => p.ReceiptId== id).Select(x=> new PaymentModel()
            {
                Id=x.Id,
                ReceiptId=x.ReceiptId,
                SendingAmount=x.SendingAmount,
                CreationTime=x.CreationTime,
                SenderAccountNo=x.Account.AccountNo

            }).ToList();

            return result;
        }
    }
}
