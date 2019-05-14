using System;
using System.Collections.Generic;

namespace Data
{
    public partial class BankDetails
    {
        public Guid Id { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string IfscCode { get; set; }
        public string BankName { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Branch { get; set; }
        public Guid SellerId { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Seller Seller { get; set; }
    }
}
