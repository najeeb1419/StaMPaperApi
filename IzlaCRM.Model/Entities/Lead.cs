using IzlaCRM.Entity.Common;

namespace IzlaCRM.Entity.Entities
{
    public class Lead : FullAudited, IMustHaveTenant
    {
        public int TenantId { get; set; }
        public int LeadNo { get; set; }


}
}
