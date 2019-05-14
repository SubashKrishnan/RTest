using System;
using System.Collections.Generic;

namespace Data
{
    public partial class ProductDisciplineSectorMap
    {
        public Guid Id { get; set; }
        public Guid ProductSectorId { get; set; }
        public Guid ProductDisciplineId { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ProductDiscipline ProductDiscipline { get; set; }
        public virtual ProductSector ProductSector { get; set; }
    }
}
