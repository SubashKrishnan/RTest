using System;
using System.Collections.Generic;

namespace Data
{
    public partial class CustomProductSpecification
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Product Product { get; set; }
    }
}
