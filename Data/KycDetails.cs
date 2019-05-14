using System;
using System.Collections.Generic;

namespace Data
{
    public partial class KycDetails
    {
        public Guid Id { get; set; }
        public string Pan { get; set; }
        public string AddressProffUrl { get; set; }
        public string CancelledChequeUrl { get; set; }
        public Guid SellerId { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Seller Seller { get; set; }
    }
}
