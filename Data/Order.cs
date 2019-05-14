using System;
using System.Collections.Generic;

namespace Data
{
    public partial class Order
    {
        public Order()
        {
            OrderProduct = new HashSet<OrderProduct>();
            Payment = new HashSet<Payment>();
            PaymentDirect = new HashSet<PaymentDirect>();
        }

        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid ShippingAddressId { get; set; }
        public Guid BillingAddressId { get; set; }
        public string TxnAmount { get; set; }
        public string Status { get; set; }
        public string PaymentType { get; set; }
        public string PaymentDate { get; set; }
        public string Ip { get; set; }
        public long InvoiceNo { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual UserAddress BillingAddress { get; set; }
        public virtual User Customer { get; set; }
        public virtual UserAddress ShippingAddress { get; set; }
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
        public virtual ICollection<PaymentDirect> PaymentDirect { get; set; }
    }
}
