using IzlaCRM.Entity.Common;

namespace IzlaCRM.Entity.Entities
{
    public class LookUp : FullAudited
    {
        public int? TenantId { get; set; }
        public string DisplayName { get; set; }
        public string Value { get; set; }
        public string Style { get; set; }


    }
}
