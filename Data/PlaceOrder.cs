using System;
using System.Collections.Generic;

namespace Data
{
    public partial class PlaceOrder
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid CartId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid ProductId { get; set; }
        public Guid? MutualproductId { get; set; }
        public long Quantity { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public short Type { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual User Customer { get; set; }
        public virtual MutualProduct Mutualproduct { get; set; }
        public virtual Product Product { get; set; }
    }
}
