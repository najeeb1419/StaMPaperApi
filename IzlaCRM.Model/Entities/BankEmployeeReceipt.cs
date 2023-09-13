using IzlaCRM.Entity.Common;

namespace IzlaCRM.Entity.Entities
{
    public class BankEmployeeReceipt : FullAudited
    {
        public virtual int TenantId { get; set; }
        public int BankemployeeId { get; set; }
        public virtual BankEmployee BankeEmployee { get; set; }
        public decimal Amount { get; set; }
        public decimal RemainingAmount { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public int LookUpId { get; set; }
        public virtual LookUp LookUp { get; set; }
        public bool IsActive { get; set; }


    }
}
