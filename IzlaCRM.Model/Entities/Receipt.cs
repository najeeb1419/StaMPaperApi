using IzlaCRM.Entity.Common;

namespace IzlaCRM.Entity.Entities
{
    public class Receipt : FullAudited
    {
        public virtual int TenantId { get; set; }
        public int MemberId { get; set; }
        public virtual Member Member { get; set; }
        public decimal Amount { get; set; }
        public decimal RemainingAmount { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public int LookUpId { get; set; }
        public virtual LookUp LookUp { get; set; }
        public bool IsActive { get; set; }


    }
}
