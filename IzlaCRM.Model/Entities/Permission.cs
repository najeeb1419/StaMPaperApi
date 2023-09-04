using IzlaCRM.Entity.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzlaCRM.Entity.Entities
{
    public class Permission :FullAudited, IMustHaveTenant
    {
        public int TenantId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int? ParentId { get; set; }
        [ForeignKey("ParentId")]
        public Permission ChiledPermission { get; set; }
    }
}
