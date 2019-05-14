using System;
using System.Collections.Generic;

namespace Data
{
    public partial class UserAddress
    {
        public UserAddress()
        {
            OrderBillingAddress = new HashSet<Order>();
            OrderShippingAddress = new HashSet<Order>();
        }

        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string NameOfAddress { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Property { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
        public int AddressType { get; set; }
        public int? SetAsDefault { get; set; }
        public int Isactive { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Order> OrderBillingAddress { get; set; }
        public virtual ICollection<Order> OrderShippingAddress { get; set; }
    }
}
