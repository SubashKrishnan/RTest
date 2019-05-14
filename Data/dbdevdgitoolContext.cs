using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Data
{
    public partial class dbdevdgitoolContext : DbContext
    {
        public dbdevdgitoolContext()
        {
        }

        public dbdevdgitoolContext(DbContextOptions<dbdevdgitoolContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<BankDetails> BankDetails { get; set; }
        public virtual DbSet<BusineesDetails> BusineesDetails { get; set; }
        public virtual DbSet<BusinessAddress> BusinessAddress { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<ChatDetail> ChatDetail { get; set; }
        public virtual DbSet<CustomProductSpecification> CustomProductSpecification { get; set; }
        public virtual DbSet<ForgotPassword> ForgotPassword { get; set; }
        public virtual DbSet<InstantQuote> InstantQuote { get; set; }
        public virtual DbSet<KycDetails> KycDetails { get; set; }
        public virtual DbSet<LookUp> LookUp { get; set; }
        public virtual DbSet<LookUpGroup> LookUpGroup { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<MenuProduct> MenuProduct { get; set; }
        public virtual DbSet<MutualProduct> MutualProduct { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderProduct> OrderProduct { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<PaymentDirect> PaymentDirect { get; set; }
        public virtual DbSet<PlaceOrder> PlaceOrder { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }
        public virtual DbSet<ProductCategoryDisciplineMap> ProductCategoryDisciplineMap { get; set; }
        public virtual DbSet<ProductCategorySpecification> ProductCategorySpecification { get; set; }
        public virtual DbSet<ProductChat> ProductChat { get; set; }
        public virtual DbSet<ProductDelivery> ProductDelivery { get; set; }
        public virtual DbSet<ProductDetail> ProductDetail { get; set; }
        public virtual DbSet<ProductDiscipline> ProductDiscipline { get; set; }
        public virtual DbSet<ProductDisciplineProductMenuMap> ProductDisciplineProductMenuMap { get; set; }
        public virtual DbSet<ProductDisciplineSectorMap> ProductDisciplineSectorMap { get; set; }
        public virtual DbSet<ProductImage> ProductImage { get; set; }
        public virtual DbSet<ProductSearch> ProductSearch { get; set; }
        public virtual DbSet<ProductSector> ProductSector { get; set; }
        public virtual DbSet<ProductSeen> ProductSeen { get; set; }
        public virtual DbSet<ProductSpecification> ProductSpecification { get; set; }
        public virtual DbSet<ProductSupplyLocation> ProductSupplyLocation { get; set; }
        public virtual DbSet<ProductTag> ProductTag { get; set; }
        public virtual DbSet<RefreshToken> RefreshToken { get; set; }
        public virtual DbSet<Seller> Seller { get; set; }
        public virtual DbSet<Slider> Slider { get; set; }
        public virtual DbSet<Specification> Specification { get; set; }
        public virtual DbSet<StoreDetails> StoreDetails { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserAddress> UserAddress { get; set; }
        public virtual DbSet<UserOnlineHistory> UserOnlineHistory { get; set; }
        public virtual DbSet<UserVerification> UserVerification { get; set; }
        public virtual DbSet<Wishlist> Wishlist { get; set; }

        // Unable to generate entity type for table 'dbo.Test CI'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=tcp:dgitools.database.windows.net,1433;Initial Catalog=db-dev-dgitool;User ID=dgitools;Password=Toolsdgi@123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isactive)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasColumnName("MOBILE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Admin)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Admin_User");
            });

            modelBuilder.Entity<BankDetails>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasColumnName("ACCOUNT_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasColumnName("ACCOUNT_NUMBER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasColumnName("BANK_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasColumnName("BRANCH")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("CITY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[IstDateTime](getdate()))");

                entity.Property(e => e.IfscCode)
                    .IsRequired()
                    .HasColumnName("IFSC_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SellerId).HasColumnName("SELLER_ID");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("STATE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.BankDetails)
                    .HasForeignKey(d => d.SellerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BankDetails_User");
            });

            modelBuilder.Entity<BusineesDetails>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[IstDateTime](getdate()))");

                entity.Property(e => e.Gstin)
                    .HasColumnName("GSTIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SellerId).HasColumnName("SELLER_ID");

                entity.Property(e => e.Tan)
                    .HasColumnName("TAN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.BusineesDetails)
                    .HasForeignKey(d => d.SellerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BusineesDetails_User");
            });

            modelBuilder.Entity<BusinessAddress>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("CITY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasColumnName("DISTRICT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Postcode)
                    .IsRequired()
                    .HasColumnName("POSTCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Property)
                    .IsRequired()
                    .HasColumnName("PROPERTY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SellerId).HasColumnName("SELLER_ID");

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasColumnName("STREET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.BusinessAddress)
                    .HasForeignKey(d => d.SellerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BusinessAddress_User");
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[IstDateTime](getdate()))");

                entity.Property(e => e.CustomerId).HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.FromDate)
                    .HasColumnName("FROM_DATE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MutualproductId).HasColumnName("MUTUALPRODUCT_ID");

                entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.Property(e => e.ToDate)
                    .HasColumnName("TO_DATE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasColumnName("TYPE");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cart_Customer");

                entity.HasOne(d => d.Mutualproduct)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.MutualproductId)
                    .HasConstraintName("FK_Cart_MutualProduct");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cart_Product");
            });

            modelBuilder.Entity<ChatDetail>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[IstDateTime](getdate()))");

                entity.Property(e => e.IsRead).HasDefaultValueSql("((1))");

                entity.Property(e => e.Message)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Chat)
                    .WithMany(p => p.ChatDetail)
                    .HasForeignKey(d => d.ChatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChatDetail_ProductChat");
            });

            modelBuilder.Entity<CustomProductSpecification>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CustomProductSpecification)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomProductSpecification_Product");
            });

            modelBuilder.Entity<ForgotPassword>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ForgotPassword)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ForgotPassword_User");
            });

            modelBuilder.Entity<InstantQuote>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCategoryId).HasColumnName("PRODUCT_CATEGORY_ID");

                entity.Property(e => e.ProductDisciplineId).HasColumnName("PRODUCT_DISCIPLINE_ID");

                entity.Property(e => e.ProductSectorId).HasColumnName("PRODUCT_SECTOR_ID");

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.InstantQuote)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstantQuote_ProductCategory");

                entity.HasOne(d => d.ProductDiscipline)
                    .WithMany(p => p.InstantQuote)
                    .HasForeignKey(d => d.ProductDisciplineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstantQuote_ProductDiscipline");

                entity.HasOne(d => d.ProductSector)
                    .WithMany(p => p.InstantQuote)
                    .HasForeignKey(d => d.ProductSectorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstantQuote_ProductSector");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.InstantQuote)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InstantQuote_User");
            });

            modelBuilder.Entity<KycDetails>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AddressProffUrl)
                    .IsRequired()
                    .HasColumnName("ADDRESS_PROFF_URL")
                    .IsUnicode(false);

                entity.Property(e => e.CancelledChequeUrl)
                    .IsRequired()
                    .HasColumnName("CANCELLED_CHEQUE_URL")
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[IstDateTime](getdate()))");

                entity.Property(e => e.Pan)
                    .HasColumnName("PAN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SellerId).HasColumnName("SELLER_ID");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.KycDetails)
                    .HasForeignKey(d => d.SellerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KycDetails_User");
            });

            modelBuilder.Entity<LookUp>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[IstDateTime](getdate()))");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.LookupGroup)
                    .WithMany(p => p.LookUp)
                    .HasForeignKey(d => d.LookupGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LookupGroup_Lookup");
            });

            modelBuilder.Entity<LookUpGroup>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[IstDateTime](getdate()))");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CategoryId).HasColumnName("CATEGORY_ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.Property(e => e.DisciplineId).HasColumnName("DISCIPLINE_ID");

                entity.Property(e => e.Isactive)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SectorId).HasColumnName("SECTOR_ID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Menu)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Menu_ProductCategory");

                entity.HasOne(d => d.Discipline)
                    .WithMany(p => p.Menu)
                    .HasForeignKey(d => d.DisciplineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Menu_ProductDiscipline");

                entity.HasOne(d => d.Sector)
                    .WithMany(p => p.Menu)
                    .HasForeignKey(d => d.SectorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Menu_ProductSector");
            });

            modelBuilder.Entity<MenuProduct>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.Property(e => e.Isactive)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MutualProduct>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Cost).HasColumnName("COST");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[IstDateTime](getdate()))");

                entity.Property(e => e.CustomerId).HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.Delivery).HasColumnName("DELIVERY");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FromDate)
                    .HasColumnName("FROM_DATE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.Property(e => e.SellerId).HasColumnName("SELLER_ID");

                entity.Property(e => e.ShippingCost).HasColumnName("SHIPPING_COST");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.ToDate)
                    .HasColumnName("TO_DATE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.MutualProduct)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MutualProduct_User");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.MutualProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MutualProduct_Product");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.MutualProduct)
                    .HasForeignKey(d => d.SellerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MutualProduct_Seller");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasIndex(e => e.InvoiceNo)
                    .HasName("UQ__Order__0CE77199450D432C")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BillingAddressId).HasColumnName("BILLING_ADDRESS_ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[IstDateTime](getdate()))");

                entity.Property(e => e.CustomerId).HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.InvoiceNo)
                    .HasColumnName("INVOICE_NO")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDate)
                    .HasColumnName("PAYMENT_DATE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .HasColumnName("PAYMENT_TYPE")
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddressId).HasColumnName("SHIPPING_ADDRESS_ID");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TxnAmount)
                    .HasColumnName("TXN_AMOUNT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.BillingAddress)
                    .WithMany(p => p.OrderBillingAddress)
                    .HasForeignKey(d => d.BillingAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_UserAddress1");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_User");

                entity.HasOne(d => d.ShippingAddress)
                    .WithMany(p => p.OrderShippingAddress)
                    .HasForeignKey(d => d.ShippingAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_UserAddress");
            });

            modelBuilder.Entity<OrderProduct>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Confirmed).HasColumnName("CONFIRMED");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[IstDateTime](getdate()))");

                entity.Property(e => e.Delivered)
                    .HasColumnName("DELIVERED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FromDate)
                    .HasColumnName("FROM_DATE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MutualproductId).HasColumnName("MUTUALPRODUCT_ID");

                entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");

                entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.Property(e => e.ToDate)
                    .HasColumnName("TO_DATE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasColumnName("TYPE");

                entity.HasOne(d => d.Mutualproduct)
                    .WithMany(p => p.OrderProduct)
                    .HasForeignKey(d => d.MutualproductId)
                    .HasConstraintName("FK_OrderProduct_MutualProduct");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderProduct)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderProduct_Order");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderProduct_Product");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Bankname)
                    .HasColumnName("BANKNAME")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Banktxnid)
                    .HasColumnName("BANKTXNID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.Property(e => e.Gatewayname)
                    .HasColumnName("GATEWAYNAME")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Mid)
                    .IsRequired()
                    .HasColumnName("MID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");

                entity.Property(e => e.Paymentmode)
                    .HasColumnName("PAYMENTMODE")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Refundamt)
                    .HasColumnName("REFUNDAMT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Respcode)
                    .IsRequired()
                    .HasColumnName("RESPCODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Respmsg)
                    .HasColumnName("RESPMSG")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Txnamount)
                    .IsRequired()
                    .HasColumnName("TXNAMOUNT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Txndate)
                    .HasColumnName("TXNDATE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Txnid)
                    .IsRequired()
                    .HasColumnName("TXNID")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Txntype)
                    .HasColumnName("TXNTYPE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment_Order");
            });

            modelBuilder.Entity<PaymentDirect>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Approved).HasColumnName("APPROVED");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");

                entity.Property(e => e.Txnamount)
                    .IsRequired()
                    .HasColumnName("TXNAMOUNT")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Txndate)
                    .HasColumnName("TXNDATE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Txnid)
                    .HasColumnName("TXNID")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.PaymentDirect)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentDirect_Order");
            });

            modelBuilder.Entity<PlaceOrder>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CartId).HasColumnName("CART_ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[IstDateTime](getdate()))");

                entity.Property(e => e.CustomerId).HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.FromDate)
                    .HasColumnName("FROM_DATE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MutualproductId).HasColumnName("MUTUALPRODUCT_ID");

                entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");

                entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.Property(e => e.ToDate)
                    .HasColumnName("TO_DATE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasColumnName("TYPE");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.PlaceOrder)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlaceOrder_User");

                entity.HasOne(d => d.Mutualproduct)
                    .WithMany(p => p.PlaceOrder)
                    .HasForeignKey(d => d.MutualproductId)
                    .HasConstraintName("FK_PlaceOrder_MutualProduct");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.PlaceOrder)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlaceOrder_Product");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Capability).HasColumnName("CAPABILITY");

                entity.Property(e => e.Cost).HasColumnName("COST");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.Property(e => e.CutCost).HasColumnName("CUT_COST");

                entity.Property(e => e.Delivery).HasColumnName("DELIVERY");

                entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCategoryId).HasColumnName("PRODUCT_CATEGORY_ID");

                entity.Property(e => e.ProductDescriptionId).HasColumnName("PRODUCT_DESCRIPTION_ID");

                entity.Property(e => e.ProductDisciplineId).HasColumnName("PRODUCT_DISCIPLINE_ID");

                entity.Property(e => e.ProductSectorId).HasColumnName("PRODUCT_SECTOR_ID");

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.Property(e => e.SellerId).HasColumnName("SELLER_ID");

                entity.Property(e => e.ShippingCost).HasColumnName("SHIPPING_COST");

                entity.Property(e => e.ShowTop).HasColumnName("SHOW_TOP");

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_ProductCategory");

                entity.HasOne(d => d.ProductDescription)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.ProductDescriptionId)
                    .HasConstraintName("FK_Product_ProductDetail");

                entity.HasOne(d => d.ProductDiscipline)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.ProductDisciplineId)
                    .HasConstraintName("FK_Product_ProductDiscipline");

                entity.HasOne(d => d.ProductSector)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.ProductSectorId)
                    .HasConstraintName("FK_Product_ProductSector");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.SellerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Seller");
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.Property(e => e.Isactive)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductCategoryDisciplineMap>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.ProductCategoryDisciplineMap)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductCategoryDisciplineMap_ProductCategory");

                entity.HasOne(d => d.ProductDiscipline)
                    .WithMany(p => p.ProductCategoryDisciplineMap)
                    .HasForeignKey(d => d.ProductDisciplineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductCategoryDisciplineMap_ProductDiscipline");
            });

            modelBuilder.Entity<ProductCategorySpecification>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[IstDateTime](getdate()))");

                entity.Property(e => e.IsRequired).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.ProductCategorySpecification)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductCategorySpecification_ProductCategory");

                entity.HasOne(d => d.Specification)
                    .WithMany(p => p.ProductCategorySpecification)
                    .HasForeignKey(d => d.SpecificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductCategorySpecification_Specification");
            });

            modelBuilder.Entity<ProductChat>(entity =>
            {
                entity.HasIndex(e => new { e.ProductId, e.CustomerId, e.VendorId })
                    .HasName("ucChat")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ProductChat)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductChat_Customer");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductChat)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductChat_Product");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.ProductChat)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductChat_Vendor");
            });

            modelBuilder.Entity<ProductDelivery>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Arrived)
                    .HasColumnName("ARRIVED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ArrivedMsg)
                    .HasColumnName("ARRIVED_MSG")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CanceledMsg)
                    .HasColumnName("CANCELED_MSG")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Confirmed)
                    .HasColumnName("CONFIRMED")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.Property(e => e.DeliverStatus)
                    .HasColumnName("DELIVER_STATUS")
                    .HasDefaultValueSql("((20))");

                entity.Property(e => e.Delivered)
                    .HasColumnName("DELIVERED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeliveredMsg)
                    .HasColumnName("DELIVERED_MSG")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Dispatched)
                    .HasColumnName("DISPATCHED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DispatchedMsg)
                    .HasColumnName("DISPATCHED_MSG")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OrderProductId).HasColumnName("ORDER_PRODUCT_ID");

                entity.Property(e => e.Outfordelivery)
                    .HasColumnName("OUTFORDELIVERY")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OutfordeliveryMsg)
                    .HasColumnName("OUTFORDELIVERY_MSG")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.OrderProduct)
                    .WithMany(p => p.ProductDelivery)
                    .HasForeignKey(d => d.OrderProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductDelivery_OrderProduct");
            });

            modelBuilder.Entity<ProductDetail>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.ShortDescription).IsUnicode(false);
            });

            modelBuilder.Entity<ProductDiscipline>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.Property(e => e.Isactive)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductDisciplineProductMenuMap>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.HasOne(d => d.ProductDiscipline)
                    .WithMany(p => p.ProductDisciplineProductMenuMap)
                    .HasForeignKey(d => d.ProductDisciplineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductDisciplineProductMenuMap_ProductDiscipline");

                entity.HasOne(d => d.ProductMenu)
                    .WithMany(p => p.ProductDisciplineProductMenuMap)
                    .HasForeignKey(d => d.ProductMenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductDisciplineProductMenuMap_MenuProduct1");
            });

            modelBuilder.Entity<ProductDisciplineSectorMap>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.HasOne(d => d.ProductDiscipline)
                    .WithMany(p => p.ProductDisciplineSectorMap)
                    .HasForeignKey(d => d.ProductDisciplineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductDisciplineSectorMap_ProductDiscipline");

                entity.HasOne(d => d.ProductSector)
                    .WithMany(p => p.ProductDisciplineSectorMap)
                    .HasForeignKey(d => d.ProductSectorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductCategoryDisciplineMap_ProductSector");
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.Property(e => e.FileUrl)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductImage)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductImage_Product");
            });

            modelBuilder.Entity<ProductSearch>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.Property(e => e.Isactive)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");

                entity.Property(e => e.ProductSearchKey)
                    .IsRequired()
                    .HasColumnName("PRODUCT_SEARCH_KEY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductSearch)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductSearch_Product");
            });

            modelBuilder.Entity<ProductSector>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.Property(e => e.Isactive)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductSeen>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[IstDateTime](getdate()))");

                entity.Property(e => e.CustomerId).HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ProductSeen)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductSeen_User");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductSeen)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductSeen_Product");
            });

            modelBuilder.Entity<ProductSpecification>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductSpecification)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductSpecification_Product");

                entity.HasOne(d => d.Specification)
                    .WithMany(p => p.ProductSpecification)
                    .HasForeignKey(d => d.SpecificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductSpecification_Specification");
            });

            modelBuilder.Entity<ProductSupplyLocation>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.Property(e => e.Isactive)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasColumnName("LOCATION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductSupplyLocation)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductSupplyLocation_Product");
            });

            modelBuilder.Entity<ProductTag>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.Property(e => e.Isactive)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RefreshToken>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RefreshToken)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RefreshToken_User");
            });

            modelBuilder.Entity<Seller>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isactive)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MasterSellerId).HasColumnName("MASTER_SELLER_ID");

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasColumnName("MOBILE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProfileStatus)
                    .HasColumnName("PROFILE_STATUS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SellerType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Verified)
                    .HasColumnName("VERIFIED")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Seller)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Seller_User");
            });

            modelBuilder.Entity<Slider>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[IstDateTime](getdate()))");

                entity.Property(e => e.Isactive)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PanelType).HasColumnName("PANEL_TYPE");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Specification>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[IstDateTime](getdate()))");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StoreDetails>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.BusinessDescription)
                    .IsRequired()
                    .HasColumnName("BUSINESS_DESCRIPTION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[IstDateTime](getdate()))");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasColumnName("DISPLAY_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SellerId).HasColumnName("SELLER_ID");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.StoreDetails)
                    .HasForeignKey(d => d.SellerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StoreDetails_User");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isactive)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastLogin)
                    .HasColumnName("LAST_LOGIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasColumnName("MOBILE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Verified).HasColumnName("VERIFIED");
            });

            modelBuilder.Entity<UserAddress>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AddressType).HasColumnName("ADDRESS_TYPE");

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasColumnName("DISTRICT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Isactive)
                    .HasColumnName("ISACTIVE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasColumnName("MOBILE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameOfAddress)
                    .IsRequired()
                    .HasColumnName("NAME_OF_ADDRESS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Postcode)
                    .IsRequired()
                    .HasColumnName("POSTCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Property)
                    .HasColumnName("PROPERTY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SetAsDefault).HasColumnName("SET_AS_DEFAULT");

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasColumnName("STREET")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserAddress)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerAddress_Customer");
            });

            modelBuilder.Entity<UserOnlineHistory>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ConnectionId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserOnlineHistory)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerOnlineHistory_Customer");
            });

            modelBuilder.Entity<UserVerification>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserVerification)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserVerification_User");
            });

            modelBuilder.Entity<Wishlist>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("CREATED_DATE")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("([dbo].[istdatetime](getdate()))");

                entity.Property(e => e.CustomerId).HasColumnName("CUSTOMER_ID");

                entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Wishlist)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Wishlist_Customer");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Wishlist)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Wishlist_Product");
            });
        }
    }
}
