using System;
using System.Collections.Generic;

namespace Data
{
    public partial class OrderProduct
    {
        public OrderProduct()
        {
            ProductDelivery = new HashSet<ProductDelivery>();
        }

        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public Guid? MutualproductId { get; set; }
        public long Quantity { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public short Type { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Confirmed { get; set; }
        public bool? Delivered { get; set; }

        public virtual MutualProduct Mutualproduct { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<ProductDelivery> ProductDelivery { get; set; }
    }
}
