using System;
using System.Collections.Generic;

namespace Data
{
    public partial class MenuProduct
    {
        public MenuProduct()
        {
            ProductDisciplineProductMenuMap = new HashSet<ProductDisciplineProductMenuMap>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Isactive { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<ProductDisciplineProductMenuMap> ProductDisciplineProductMenuMap { get; set; }
    }
}
