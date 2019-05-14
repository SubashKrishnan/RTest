using System;
using System.Collections.Generic;

namespace Data
{
    public partial class ForgotPassword
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual User User { get; set; }
    }
}
