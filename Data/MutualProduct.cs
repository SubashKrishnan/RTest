using System;
using System.Collections.Generic;

namespace Data
{
    public partial class MutualProduct
    {
        public MutualProduct()
        {
            Cart = new HashSet<Cart>();
            OrderProduct = new HashSet<OrderProduct>();
            PlaceOrder = new HashSet<PlaceOrder>();
        }

        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid ProductId { get; set; }
        public Guid SellerId { get; set; }
        public long Quantity { get; set; }
        public double? Cost { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Description { get; set; }
        public double? ShippingCost { get; set; }
        public int? Delivery { get; set; }
        public short Status { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual User Customer { get; set; }
        public virtual Product Product { get; set; }
        public virtual Seller Seller { get; set; }
        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
        public virtual ICollection<PlaceOrder> PlaceOrder { get; set; }
    }
}
