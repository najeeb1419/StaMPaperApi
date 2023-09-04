using IzlaCRM.Entity.Common;

namespace IzlaCRM.Entity.Entities
{
    public class BillingShipping : FullAudited
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public AddressTypeEnum AddressType { get; set; }

        public enum AddressTypeEnum
        {
            BillingAddress = 1,
            ShippingAddress = 2
        }


    }
}
