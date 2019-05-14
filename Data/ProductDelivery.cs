using System;
using System.Collections.Generic;

namespace Data
{
    public partial class ProductDelivery
    {
        public Guid Id { get; set; }
        public Guid OrderProductId { get; set; }
        public int? Confirmed { get; set; }
        public string CanceledMsg { get; set; }
        public bool? Dispatched { get; set; }
        public string DispatchedMsg { get; set; }
        public bool? Arrived { get; set; }
        public string ArrivedMsg { get; set; }
        public bool? Outfordelivery { get; set; }
        public string OutfordeliveryMsg { get; set; }
        public bool? Delivered { get; set; }
        public string DeliveredMsg { get; set; }
        public int DeliverStatus { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual OrderProduct OrderProduct { get; set; }
    }
}
