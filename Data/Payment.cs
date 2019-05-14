using System;
using System.Collections.Generic;

namespace Data
{
    public partial class Payment
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public string Txnid { get; set; }
        public string Banktxnid { get; set; }
        public string Txnamount { get; set; }
        public string Status { get; set; }
        public string Txntype { get; set; }
        public string Gatewayname { get; set; }
        public string Respcode { get; set; }
        public string Respmsg { get; set; }
        public string Bankname { get; set; }
        public string Mid { get; set; }
        public string Paymentmode { get; set; }
        public string Refundamt { get; set; }
        public string Txndate { get; set; }
        public string Ip { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Order Order { get; set; }
    }
}
