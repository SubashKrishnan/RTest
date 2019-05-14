using System;
using System.Collections.Generic;

namespace Data
{
    public partial class UserOnlineHistory
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string ConnectionId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsOnline { get; set; }

        public virtual User User { get; set; }
    }
}
