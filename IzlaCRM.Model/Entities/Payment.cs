using IzlaCRM.Entity.Common;

namespace IzlaCRM.Entity.Entities
{
    public class Payment : FullAudited
    {
        public virtual int TenantId { get; set; }
        public int AccountId { get; set; }
        public virtual Account Account { get; set; }
        public int ReceiptId { get; set; }
        public virtual Receipt Receipt { get; set; }
        public decimal SendingAmount { get; set; }


    }
}
