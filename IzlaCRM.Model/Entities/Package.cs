using IzlaCRM.Entity.Common;

namespace IzlaCRM.Entity.Entities
{
    public class Package : FullAudited, IMustHaveTenant
    {
        public int TenantId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
