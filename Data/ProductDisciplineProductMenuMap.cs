using System;
using System.Collections.Generic;

namespace Data
{
    public partial class ProductDisciplineProductMenuMap
    {
        public Guid Id { get; set; }
        public Guid ProductMenuId { get; set; }
        public Guid ProductDisciplineId { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ProductDiscipline ProductDiscipline { get; set; }
        public virtual MenuProduct ProductMenu { get; set; }
    }
}
