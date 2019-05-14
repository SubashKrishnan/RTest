using System;
using System.Collections.Generic;

namespace Data
{
    public partial class LookUp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public int LookupGroupId { get; set; }

        public virtual LookUpGroup LookupGroup { get; set; }
    }
}
