using QuanLyBanHang.DAL;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyBanHang.DAL
{
    public partial class QLDB_DB : DbContext
    {
        public QLDB_DB()
            : base("name=QLDB_DB")
        {
        }

        // Định nghĩa các tập hợp DbSet (các bảng) trong cơ sở dữ liệu
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Order_Items> Order_Items { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<sysdiagram> Sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ListAnhSP> ListAnhSPs { get; set; } // DbSet cho bảng ảnh sản phẩm


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // --- CẤU HÌNH LISTANHSP ---
            // Định nghĩa Khóa chính cho ListAnhSP (Khắc phục lỗi trước đó)
            modelBuilder.Entity<ListAnhSP>()
                .HasKey(e => e.image_id);

            // Cấu hình mối quan hệ One-to-Many giữa Product và ListAnhSP (có Cascade Delete)
            modelBuilder.Entity<Product>()
                .HasMany(e => e.ListAnhSPs)
                .WithRequired(e => e.Product)
                .HasForeignKey(e => e.product_id)
                .WillCascadeOnDelete(true);

            // --- CẤU HÌNH PRODUCT ---
            // Khôi phục cấu hình Product từ code gốc
            modelBuilder.Entity<Product>()
                .Property(e => e.barcode)
                .IsUnicode(false);

            // Khôi phục mối quan hệ Product và Order_Items
            modelBuilder.Entity<Product>()
                .HasMany(e => e.Order_Items)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            // *** Cấu hình mô tả sản phẩm (Để tránh lỗi font Unicode) ***
            // Nếu cột description trong SQL là NVARCHAR, hãy dùng IsUnicode(true)
            modelBuilder.Entity<Product>()
                 .Property(e => e.description)
                 .IsUnicode(true);


            // --- CẤU HÌNH USER ---
            // Khôi phục cấu hình User từ code gốc
            modelBuilder.Entity<User>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}