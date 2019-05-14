using System;
using System.Collections.Generic;

namespace Data
{
    public partial class PaymentDirect
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public string Txnamount { get; set; }
        public string Txnid { get; set; }
        public string Txndate { get; set; }
        public bool Approved { get; set; }
        public string Ip { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Order Order { get; set; }
    }
}
