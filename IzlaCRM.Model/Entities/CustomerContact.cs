using IzlaCRM.Entity.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace IzlaCRM.Entity.Entities
{
    public class CustomerContact : FullAudited
    {
        public string FName { get; set; }
        public string LName { get; set; }

        public int DesignationId { get; set; }
        public virtual Role Designation { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }   
        public string Direction { get; set; }
        public string Password { get; set; }
        public bool SetPrimaryContact { get; set; }
        public bool SendSetPasswordEmail { get; set;}
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }  
    }
}
