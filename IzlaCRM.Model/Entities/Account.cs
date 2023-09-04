using IzlaCRM.Entity.Common;

namespace IzlaCRM.Entity.Entities
{
    public class Account :  FullAudited
    {
        public virtual int TenantId { get; set; }
        public string Name { get; set; }
        public string AccountNo { get; set; }
        public bool IsActive { get; set; }

    }
}
