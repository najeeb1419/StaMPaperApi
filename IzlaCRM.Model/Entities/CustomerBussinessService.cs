using IzlaCRM.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzlaCRM.Entity.Entities
{
    public class CustomerBussinessService : FullAudited, IMustHaveTenant
    {
        public int TenantId { get; set; }
        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }
        public int CustomerBusinessInfoId { get; set; }
        public virtual CustomerBusinessInfo CustomerBusinessInfo { get; set; }
    }
}
