using IzlaCRM.Entity.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace IzlaCRM.Entity.Entities
{
    public class User : FullAudited
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public int TenantId { get; set; }
        public virtual Tenant Tenant { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<UserRole> userRoles { get; set; }
    }
}
