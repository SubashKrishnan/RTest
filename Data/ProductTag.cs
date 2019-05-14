using System;
using System.Collections.Generic;

namespace Data
{
    public partial class ProductTag
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Isactive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
