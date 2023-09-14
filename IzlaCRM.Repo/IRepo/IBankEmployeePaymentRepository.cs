using IzlaCRM.Entity.Entities;
using IzlaCRM.Entity.Models;

namespace IzlaCRM.Repo.IRepo
{
    public interface IBankEmployeePaymentRepository : IGenericRepository<BankEmployeePayment>
    {
        List<BankEmployeePaymentModel> GetBankEmployeePaymentByReceiptId(int id);
    }
}
