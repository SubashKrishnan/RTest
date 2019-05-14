using System;
using System.Collections.Generic;

namespace Data
{
    public partial class ProductSector
    {
        public ProductSector()
        {
            InstantQuote = new HashSet<InstantQuote>();
            Menu = new HashSet<Menu>();
            Product = new HashSet<Product>();
            ProductDisciplineSectorMap = new HashSet<ProductDisciplineSectorMap>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Isactive { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<InstantQuote> InstantQuote { get; set; }
        public virtual ICollection<Menu> Menu { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<ProductDisciplineSectorMap> ProductDisciplineSectorMap { get; set; }
    }
}
