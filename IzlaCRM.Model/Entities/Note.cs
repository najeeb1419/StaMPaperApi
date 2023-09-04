using IzlaCRM.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzlaCRM.Entity.Entities
{
    public class Note : Audited, IMustHaveTenant
    {


        public int LeadProfileId { get; set; }
        public virtual LeadProfile LeadProfile { get; set; }
        public int Userid { get; set; }
        public virtual User User { get; set; }
        public string Description { get; set; }
        public int TenantId { get; set; }

        public bool IsActive { get; set; }
        public string? FileName { get; set; }
        public string? FileExtension { get; set; }
        public string? FilePath { get; set; }
    }
}
