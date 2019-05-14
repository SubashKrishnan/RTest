using System;
using System.Collections.Generic;

namespace Data
{
    public partial class BusineesDetails
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Gstin { get; set; }
        public string Tan { get; set; }
        public Guid SellerId { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Seller Seller { get; set; }
    }
}
