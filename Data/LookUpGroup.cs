using System;
using System.Collections.Generic;

namespace Data
{
    public partial class LookUpGroup
    {
        public LookUpGroup()
        {
            LookUp = new HashSet<LookUp>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<LookUp> LookUp { get; set; }
    }
}
