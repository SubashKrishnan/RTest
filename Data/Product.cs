using System;
using System.Collections.Generic;

namespace Data
{
    public partial class Product
    {
        public Product()
        {
            Cart = new HashSet<Cart>();
            CustomProductSpecification = new HashSet<CustomProductSpecification>();
            MutualProduct = new HashSet<MutualProduct>();
            OrderProduct = new HashSet<OrderProduct>();
            PlaceOrder = new HashSet<PlaceOrder>();
            ProductChat = new HashSet<ProductChat>();
            ProductImage = new HashSet<ProductImage>();
            ProductSearch = new HashSet<ProductSearch>();
            ProductSeen = new HashSet<ProductSeen>();
            ProductSpecification = new HashSet<ProductSpecification>();
            ProductSupplyLocation = new HashSet<ProductSupplyLocation>();
            Wishlist = new HashSet<Wishlist>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public double? CutCost { get; set; }
        public long Quantity { get; set; }
        public double ShippingCost { get; set; }
        public int? Capability { get; set; }
        public int? Delivery { get; set; }
        public Guid ProductCategoryId { get; set; }
        public Guid? ProductDisciplineId { get; set; }
        public Guid? ProductSectorId { get; set; }
        public Guid SellerId { get; set; }
        public int Isactive { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? ProductDescriptionId { get; set; }
        public bool ShowTop { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ProductDetail ProductDescription { get; set; }
        public virtual ProductDiscipline ProductDiscipline { get; set; }
        public virtual ProductSector ProductSector { get; set; }
        public virtual Seller Seller { get; set; }
        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<CustomProductSpecification> CustomProductSpecification { get; set; }
        public virtual ICollection<MutualProduct> MutualProduct { get; set; }
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
        public virtual ICollection<PlaceOrder> PlaceOrder { get; set; }
        public virtual ICollection<ProductChat> ProductChat { get; set; }
        public virtual ICollection<ProductImage> ProductImage { get; set; }
        public virtual ICollection<ProductSearch> ProductSearch { get; set; }
        public virtual ICollection<ProductSeen> ProductSeen { get; set; }
        public virtual ICollection<ProductSpecification> ProductSpecification { get; set; }
        public virtual ICollection<ProductSupplyLocation> ProductSupplyLocation { get; set; }
        public virtual ICollection<Wishlist> Wishlist { get; set; }
    }
}
