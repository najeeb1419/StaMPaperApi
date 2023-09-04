using IzlaCRM.Entity.Common;

namespace IzlaCRM.Entity.Entities
{
    public class LeadProfile : FullAudited, IMustHaveTenant
    {
        public int LeadStatusId { get; set; }
        public virtual LeadStatus? LeadStatus{ get; set; }
        public int AssignedId { get; set; }
    
        public int LeadSourceId { get; set; }
        public virtual LeadSource? LeadSource { get; set; }
        public int TenantId { get; set; }
    
        public string Name { get; set; }
        public string Position { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string State { get; set; }
        public string Website { get; set; }
        public int CountryId { get; set; }
        public virtual Country? Country { get; set; }
        public int? CityId { get; set; }
        public virtual City? City { get; set; }
        public string PhoneNo { get; set; }
        public string ZipCode { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public bool PublicLead { get; set; }
        public bool ContactedToday { get; set; }
        public string IBOBussinessType { get; set; }
        public int BusinessTypeId { get; set; }
        public virtual BusinessType? BusinessType { get; set; }  
        public string BusinessNo { get; set; }
        public string IBOEmailAddress { get; set; }
        public string SecondayPhoneNo { get; set; }
        public string ReferredBy { get; set; }
        public int? LanguageId { get; set; }
        public virtual Language? Language { get; set; }
        public int? PreferTimeToCallId { get; set; }
        public virtual PreferredTimeCallBack? PreferTimeCall{ get; set; }
        public bool confirmRequestAuthorization { get; set; }
        public ICollection<LeadProfileService> leadProfileServices { get; set; }

        // kindly test and change and remove unnesossory things like CustomerBussinessService here i thing there might be LeadService  and alos about BusinessTypeId and Type 
    }
}
