using System;
using System.Collections.Generic;

namespace Data
{
    public partial class Specification
    {
        public Specification()
        {
            ProductCategorySpecification = new HashSet<ProductCategorySpecification>();
            ProductSpecification = new HashSet<ProductSpecification>();
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<ProductCategorySpecification> ProductCategorySpecification { get; set; }
        public virtual ICollection<ProductSpecification> ProductSpecification { get; set; }
    }
}
