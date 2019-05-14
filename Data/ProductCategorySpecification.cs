using System;
using System.Collections.Generic;

namespace Data
{
    public partial class ProductCategorySpecification
    {
        public Guid Id { get; set; }
        public Guid ProductCategoryId { get; set; }
        public Guid SpecificationId { get; set; }
        public bool? IsRequired { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
        public virtual Specification Specification { get; set; }
    }
}
