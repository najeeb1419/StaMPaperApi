using IzlaCRM.Entity.Common;

namespace IzlaCRM.Entity.Entities
{
    public class CustomerBusinessInfo : FullAudited
    {
        public string IBOBusinessID { get; set; }
        public string ReferredBy { get; set; }

        public string IBOEmailAddress { get; set; }
        public int BusinessTypeId { get; set; }
        public virtual BusinessType BusinessType { get; set; }
        public string BusinessNumber { get; set; }
        public string PreferredTimeForCallBack { get; set; }
        public string SecondaryPhoneNumber { get; set; }
        public int PreferredLanguageId { get; set; }
        public virtual Language Language { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<CustomerBussinessService> CustomerBussinessServices { get; set; }

    }
}
