using IzlaCRM.Entity.Entities;
using IzlaCRM.Entity.Models;

namespace IzlaCRM.Repo.IRepo
{
    public interface IReceiptRepository : IGenericRepository<Receipt>
    {
        List<ReceiptModel> GetReceipts();
    }
}
