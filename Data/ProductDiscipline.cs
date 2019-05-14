using System;
using System.Collections.Generic;

namespace Data
{
    public partial class ProductDiscipline
    {
        public ProductDiscipline()
        {
            InstantQuote = new HashSet<InstantQuote>();
            Menu = new HashSet<Menu>();
            Product = new HashSet<Product>();
            ProductCategoryDisciplineMap = new HashSet<ProductCategoryDisciplineMap>();
            ProductDisciplineProductMenuMap = new HashSet<ProductDisciplineProductMenuMap>();
            ProductDisciplineSectorMap = new HashSet<ProductDisciplineSectorMap>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Isactive { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<InstantQuote> InstantQuote { get; set; }
        public virtual ICollection<Menu> Menu { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<ProductCategoryDisciplineMap> ProductCategoryDisciplineMap { get; set; }
        public virtual ICollection<ProductDisciplineProductMenuMap> ProductDisciplineProductMenuMap { get; set; }
        public virtual ICollection<ProductDisciplineSectorMap> ProductDisciplineSectorMap { get; set; }
    }
}
