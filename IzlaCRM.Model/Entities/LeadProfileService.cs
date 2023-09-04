﻿using IzlaCRM.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzlaCRM.Entity.Entities
{
    public class LeadProfileService : FullAudited, IMustHaveTenant
    {
        public int TenantId { get; set; }
        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }
        public int ProfileId { get; set; }
        public virtual LeadProfile Profile { get; set; }
    }
}
