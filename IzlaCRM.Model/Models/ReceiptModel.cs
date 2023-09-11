using AutoMapper.Execution;
using IzlaCRM.Entity.Common;
using IzlaCRM.Entity.Entities;

namespace IzlaCRM.Entity.Models
{
    public class ReceiptModel : FullAudited
    {
        public virtual int TenantId { get; set; }
        public int MemberId { get; set; }
        public Entities.Member Member { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public int LookUpId { get; set; }
        public string Status { get; set; }
        public decimal Amount { get; set; }
        public decimal RemainingAmount { get; set; }
        public string Style { get; set; }
        public bool IsActive { get; set; }
    }
}
