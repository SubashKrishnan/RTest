using System;
using System.Collections.Generic;

namespace Data
{
    public partial class RefreshToken
    {
        public Guid Id { get; set; }
        public Guid Token { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public Guid UserId { get; set; }

        public virtual User User { get; set; }
    }
}
