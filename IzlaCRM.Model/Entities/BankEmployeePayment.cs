using IzlaCRM.Entity.Common;

namespace IzlaCRM.Entity.Entities
{
    public class BankEmployeePayment : FullAudited
    {
        public virtual int TenantId { get; set; }
        public int AccountId { get; set; }
        public virtual Account Account { get; set; }
        public int BankEmployeeReceiptId { get; set; }
        public virtual BankEmployeeReceipt BankEmployeeReceipt { get; set; }
        public decimal SendingAmount { get; set; }


    }
}
