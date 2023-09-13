using IzlaCRM.Entity.Entities;
using IzlaCRM.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzlaCRM.Repo.IRepo
{
    public interface IPaymentRepository : IGenericRepository<Payment>
    {
        List<PaymentModel> GetPaymentByReceiptId(int id);
    }
}
