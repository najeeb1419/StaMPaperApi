using IzlaCRM.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzlaCRM.Entity.Entities
{
    public class DiscountType : FullAudited, IMustHaveTenant
    {
        public int TenantId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
