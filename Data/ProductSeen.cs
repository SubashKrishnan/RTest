using System;
using System.Collections.Generic;

namespace Data
{
    public partial class ProductSeen
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid ProductId { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual User Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
