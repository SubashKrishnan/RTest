using System;
using System.Collections.Generic;

namespace Data
{
    public partial class ProductCategoryDisciplineMap
    {
        public Guid Id { get; set; }
        public Guid ProductCategoryId { get; set; }
        public Guid ProductDisciplineId { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ProductDiscipline ProductDiscipline { get; set; }
    }
}
