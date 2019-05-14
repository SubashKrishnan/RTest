using System;
using System.Collections.Generic;

namespace Data
{
    public partial class ProductSearch
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string ProductSearchKey { get; set; }
        public int Isactive { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Product Product { get; set; }
    }
}
