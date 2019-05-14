using System;
using System.Collections.Generic;

namespace Data
{
    public partial class User
    {
        public User()
        {
            Admin = new HashSet<Admin>();
            Cart = new HashSet<Cart>();
            ForgotPassword = new HashSet<ForgotPassword>();
            InstantQuote = new HashSet<InstantQuote>();
            MutualProduct = new HashSet<MutualProduct>();
            Order = new HashSet<Order>();
            PlaceOrder = new HashSet<PlaceOrder>();
            ProductChat = new HashSet<ProductChat>();
            ProductSeen = new HashSet<ProductSeen>();
            RefreshToken = new HashSet<RefreshToken>();
            Seller = new HashSet<Seller>();
            UserAddress = new HashSet<UserAddress>();
            UserOnlineHistory = new HashSet<UserOnlineHistory>();
            UserVerification = new HashSet<UserVerification>();
            Wishlist = new HashSet<Wishlist>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? LastLogin { get; set; }
        public int Isactive { get; set; }
        public DateTime CreatedDate { get; set; }
        public short UserType { get; set; }
        public short Verified { get; set; }

        public virtual ICollection<Admin> Admin { get; set; }
        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<ForgotPassword> ForgotPassword { get; set; }
        public virtual ICollection<InstantQuote> InstantQuote { get; set; }
        public virtual ICollection<MutualProduct> MutualProduct { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<PlaceOrder> PlaceOrder { get; set; }
        public virtual ICollection<ProductChat> ProductChat { get; set; }
        public virtual ICollection<ProductSeen> ProductSeen { get; set; }
        public virtual ICollection<RefreshToken> RefreshToken { get; set; }
        public virtual ICollection<Seller> Seller { get; set; }
        public virtual ICollection<UserAddress> UserAddress { get; set; }
        public virtual ICollection<UserOnlineHistory> UserOnlineHistory { get; set; }
        public virtual ICollection<UserVerification> UserVerification { get; set; }
        public virtual ICollection<Wishlist> Wishlist { get; set; }
    }
}
