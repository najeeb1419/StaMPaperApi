using IzlaCRM.Entity.Common;

namespace IzlaCRM.Entity.Entities
{
    public class BankEmployeeReceipt : FullAudited
    {
        public virtual int TenantId { get; set; }
        public int BankEmployeeId { get; set; }
        public virtual BankEmployee BankEmployee { get; set; }
        public decimal Amount { get; set; }
        public DateTime PromisedDate { get; set; }
        public int LookUpId { get; set; }
        public virtual LookUp LookUp { get; set; }
        public bool IsActive { get; set; }


    }
}
