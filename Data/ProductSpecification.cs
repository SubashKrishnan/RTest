using System;
using System.Collections.Generic;

namespace Data
{
    public partial class ProductSpecification
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid SpecificationId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Product Product { get; set; }
        public virtual Specification Specification { get; set; }
    }
}
