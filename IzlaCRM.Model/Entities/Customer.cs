using IzlaCRM.Entity.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace IzlaCRM.Entity.Entities
{
    public class Customer :FullAudited
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public string Email { get; set; }
        public int TenantId { get; set; }
        public virtual Tenant Tenant { get; set; }
        public string VATNo { get; set; }
        public string City { get; set; }
        public string PhoneNo { get; set; }

        public string State { get; set; }
        public string Website { get; set; }
        public string ZipCode { get; set; }

        public int CurrencyId { get; set; }
        public int CountryId { get; set; }
        public int LanguageId { get; set; }

        public string ImageUrl { get; set; }

        public ICollection<BillingShipping> BillingShippings { get; set; }
    }
}
