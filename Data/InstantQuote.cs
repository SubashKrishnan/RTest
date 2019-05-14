using System;
using System.Collections.Generic;

namespace Data
{
    public partial class InstantQuote
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public long Quantity { get; set; }
        public Guid ProductCategoryId { get; set; }
        public Guid ProductDisciplineId { get; set; }
        public Guid ProductSectorId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ProductDiscipline ProductDiscipline { get; set; }
        public virtual ProductSector ProductSector { get; set; }
        public virtual User User { get; set; }
    }
}
