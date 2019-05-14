using System;
using System.Collections.Generic;

namespace Data
{
    public partial class Seller
    {
        public Seller()
        {
            BankDetails = new HashSet<BankDetails>();
            BusineesDetails = new HashSet<BusineesDetails>();
            BusinessAddress = new HashSet<BusinessAddress>();
            KycDetails = new HashSet<KycDetails>();
            MutualProduct = new HashSet<MutualProduct>();
            Product = new HashSet<Product>();
            ProductChat = new HashSet<ProductChat>();
            StoreDetails = new HashSet<StoreDetails>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int Isactive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? UserId { get; set; }
        public int SellerType { get; set; }
        public int? ProfileStatus { get; set; }
        public bool? Verified { get; set; }
        public Guid? MasterSellerId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<BankDetails> BankDetails { get; set; }
        public virtual ICollection<BusineesDetails> BusineesDetails { get; set; }
        public virtual ICollection<BusinessAddress> BusinessAddress { get; set; }
        public virtual ICollection<KycDetails> KycDetails { get; set; }
        public virtual ICollection<MutualProduct> MutualProduct { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<ProductChat> ProductChat { get; set; }
        public virtual ICollection<StoreDetails> StoreDetails { get; set; }
    }
}
