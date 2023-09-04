using IzlaCRM.Entity.Common;

namespace IzlaCRM.Entity.Entities
{
    public class Member : FullAudited
    {
        public virtual int TenantId { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string CNIC { get; set; }
        public string AccountNo { get; set; }
        public string Address { get; set; }
        public string ImagePath { get; set; }
        public bool IsActive { get; set; }

    }
}
