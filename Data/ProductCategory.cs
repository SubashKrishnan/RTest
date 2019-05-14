using System;
using System.Collections.Generic;

namespace Data
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            InstantQuote = new HashSet<InstantQuote>();
            Menu = new HashSet<Menu>();
            Product = new HashSet<Product>();
            ProductCategoryDisciplineMap = new HashSet<ProductCategoryDisciplineMap>();
            ProductCategorySpecification = new HashSet<ProductCategorySpecification>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Isactive { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<InstantQuote> InstantQuote { get; set; }
        public virtual ICollection<Menu> Menu { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<ProductCategoryDisciplineMap> ProductCategoryDisciplineMap { get; set; }
        public virtual ICollection<ProductCategorySpecification> ProductCategorySpecification { get; set; }
    }
}
