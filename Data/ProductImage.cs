using System;
using System.Collections.Generic;

namespace Data
{
    public partial class ProductImage
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string FileUrl { get; set; }

        public virtual Product Product { get; set; }
    }
}
