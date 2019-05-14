using System;
using System.Collections.Generic;

namespace Data
{
    public partial class Menu
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public Guid DisciplineId { get; set; }
        public Guid SectorId { get; set; }
        public int Isactive { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ProductCategory Category { get; set; }
        public virtual ProductDiscipline Discipline { get; set; }
        public virtual ProductSector Sector { get; set; }
    }
}
