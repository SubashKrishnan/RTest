using System;
using System.Collections.Generic;

namespace Data
{
    public partial class ProductSupplyLocation
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string Location { get; set; }
        public int Isactive { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Product Product { get; set; }
    }
}
