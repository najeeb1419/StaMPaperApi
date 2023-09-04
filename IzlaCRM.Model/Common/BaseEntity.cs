using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzlaCRM.Entity.Common
{

    public interface IMustHaveTenant
    {
        int  TenantId { get; set; }
    }


    public abstract class FullAudited
    {
        [Key]
        public int Id { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? DeleterUserId { get; set; }
        public  DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }

    }

    public abstract class Audited
    {
        [Key]
        public int Id { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
    }


}
