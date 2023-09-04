using IzlaCRM.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzlaCRM.Entity.Entities
{
    public class RolePermission :FullAudited
    {   public int RoleId { get; set; }
        public virtual Role Role { get; set; }

        public int PermissionId { get; set; }
        public virtual Permission Permission { get; set; }
    }
}
