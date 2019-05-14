using System;
using System.Collections.Generic;

namespace Data
{
    public partial class StoreDetails
    {
        public Guid Id { get; set; }
        public string DisplayName { get; set; }
        public string BusinessDescription { get; set; }
        public Guid SellerId { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Seller Seller { get; set; }
    }
}
