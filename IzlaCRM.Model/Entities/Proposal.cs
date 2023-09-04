using IzlaCRM.Entity.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace IzlaCRM.Entity.Entities
{
    public class Proposal : FullAudited, IMustHaveTenant
    {
        public int TenantId { get; set; }

        public string ProjectName { get; set; }

        public  int LeadProfileId { get; set; }
        public virtual LeadProfile LeadProfile { get; set; }

        public DateTime OpenTill { get; set; }

        public int DiscountTypeId { get; set; }
        public virtual DiscountType DiscountType { get; set; }

        public int CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }

        public string status { get; set; }


        public int AssignId { get; set; }
        public int ToId { get; set; }

        public string Adress { get; set; }


        public string ZipCode { get; set; }

        public string State { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Description { get; set; }

        public int QTY { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Rate { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Tax { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public  decimal adjustment { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public  decimal totalAmount { get; set; }

}
}
