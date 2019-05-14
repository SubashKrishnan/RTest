using System;
using System.Collections.Generic;

namespace Data
{
    public partial class BusinessAddress
    {
        public Guid Id { get; set; }
        public string Property { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Postcode { get; set; }
        public Guid SellerId { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Seller Seller { get; set; }
    }
}
