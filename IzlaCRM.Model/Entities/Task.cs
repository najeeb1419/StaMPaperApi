using IzlaCRM.Entity.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzlaCRM.Entity.Entities
{
    public class Task : FullAudited, IMustHaveTenant
    {
        public int TenantId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal HourlyRate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime DueDate { get; set; }
        public string Priority { get; set; }
        public DateTime RepeatEvery { get; set; }

        public int TotalCycle { get; set; }
        public string RelatedTo { get; set; }
        public string Lead { get; set; }
        public string InsertCheckListTemplate { get; set; }

        public string Tag { get; set; }


        public string TaskDescription { get; set;}

  
    }
}
