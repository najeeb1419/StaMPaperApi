using IzlaCRM.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzlaCRM.Entity.Entities
{
    public class UserRole : FullAudited , IMustHaveTenant
    {
        public int TenantId { get; set; }   
        public int RoleId { get; set; }

        public virtual Role Role { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
