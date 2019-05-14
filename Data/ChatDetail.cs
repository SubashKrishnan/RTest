using System;
using System.Collections.Generic;

namespace Data
{
    public partial class ChatDetail
    {
        public Guid Id { get; set; }
        public bool IsCustomer { get; set; }
        public Guid ChatId { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool? IsRead { get; set; }

        public virtual ProductChat Chat { get; set; }
    }
}
