using System;
using System.Collections.Generic;

namespace Data
{
    public partial class ProductChat
    {
        public ProductChat()
        {
            ChatDetail = new HashSet<ChatDetail>();
        }

        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid VendorId { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual User Customer { get; set; }
        public virtual Product Product { get; set; }
        public virtual Seller Vendor { get; set; }
        public virtual ICollection<ChatDetail> ChatDetail { get; set; }
    }
}
