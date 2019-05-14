using System;
using System.Collections.Generic;

namespace Data
{
    public partial class Admin
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int Isactive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? UserId { get; set; }

        public virtual User User { get; set; }
    }
}
