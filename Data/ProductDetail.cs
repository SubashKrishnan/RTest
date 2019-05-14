using System;
using System.Collections.Generic;

namespace Data
{
    public partial class ProductDetail
    {
        public ProductDetail()
        {
            Product = new HashSet<Product>();
        }

        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
