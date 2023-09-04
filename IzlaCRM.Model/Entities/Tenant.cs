using IzlaCRM.Entity.Common;

namespace IzlaCRM.Entity.Entities
{
    public class Tenant:FullAudited
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }


    }
}
